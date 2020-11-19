using BusinessLogicalLayer;
using BusinessLogicalLayer.BLL;
using BusinessLogicalLayer.Extentions;
using Common;
using Entities;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FormRegisterIncome : Form
    {
        public Supplier supplier;
        private readonly IncomeBLL _incomeBLL;
        private Product _product;
        private List<IncomeItem> _incomeItems;
        private List<Income> _incomeGrid;
        private int _currentRowGrid;
        private SupplierBLL _supplierBLL;
        public FormRegisterIncome()
        {
            InitializeComponent();
            supplier = new Supplier();
            _incomeBLL = new IncomeBLL();
            _product = new Product();
            _incomeItems = new List<IncomeItem>();
            _supplierBLL = new SupplierBLL();
        }

        private void btnSelecSupp_Click(object sender, EventArgs e)
        {
            this.ClearForm();
            RenewLabelSupplier();
            _incomeItems.Clear();

            CreateSupplier();

        }

        private void RenewLabelSupplier()
        {
            lblCompanyName.Text = "Razão social: ";
            lblCNPJ.Text = "CNPJ: ";
        }

        private void CreateSupplier()
        {
            FormSearchSupplierIncome frmSearchSupp = new FormSearchSupplierIncome();
            frmSearchSupp.ShowDialog();

            supplier = frmSearchSupp.supplier;
            if (supplier != null)
            {
                btnSelectProduct.Enabled = true;
            }

            lblCompanyName.Text += supplier.CompanyName;
            lblCNPJ.Text += supplier.CNPJ.InsertMaskCNPJ();
        }

        private void picSupplierClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelectProduct_Click(object sender, EventArgs e)
        {
            RenewLabelProduct();
            SearchProductBySupplier();
        }

        private void SearchProductBySupplier()
        {
            FormSearchProduct frmProduto = new FormSearchProduct();
            frmProduto.supplier = supplier;

            frmProduto.ShowDialog();

            _product = frmProduto.product;

            lblProdID.Text += _product.ID.ToString();
            lblProdName.Text += _product.Name;
            lblProdDesc.Text += _product.Description;
        }

        private void FormRegisterIncome_Load(object sender, EventArgs e)
        {
            btnSelectProduct.Enabled = false;
            UpdateGrid();
        }

        private void btnIncomeRegister_Click(object sender, EventArgs e)
        {
            Income income = CreateIncome();

            Response response = _incomeBLL.Register(income);

            MessageBox.Show(response.Message);

            if (response.Success)
            {
                this.ClearForm();
                RenewTextBoxValue();
                RenewLabelSupplier();
                RenewLabelProduct();
                UpdateGrid();
            }
        }

        private void UpdateComponentsRegister()
        {
            btnIncomeRegister.Text = "Cadastrar";
            RenewTextBoxValue();
        }



        private Income CreateIncome()
        {
            Income income = new Income();

            income.EmployeeID = FormMain.employee.ID;
            income.SupplierID = supplier.ID;
            income.EntryDate = DateTime.Now;
            income.IncomeItems = _incomeItems;

            income.TotalValue = Convert.ToDouble(txtTotalValue.Text);
            return income;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            CreateIncomeItem();
            RenewTextBoxValue();
        }

        private void CreateIncomeItem()
        {
            IncomeItem incomeItem = new IncomeItem();
            Response response = _incomeBLL.ValidateIncomeItem(_product.ID, txtProdPrice.Text, txtProdQuantity.Text, txtProductProfit.Text);
            if (!response.Success)
            {
                MessageBox.Show(response.Message);
                return;
            }
            incomeItem.ProductID = response.ProductId;
            incomeItem.Quantity = response.ProductQuantity;
            incomeItem.UnityPrice = response.ProductPrice;
            incomeItem.Profit = response.ProdcutProfit;

            _incomeItems.Add(incomeItem);

            UpdateToTalValue();
        }

        private void UpdateToTalValue()
        {
            double totalValue = 0.0;
            foreach (var item in _incomeItems)
            {
                totalValue += item.UnityPrice * ((double)item.Quantity);
            }

            txtTotalValue.Text = totalValue.ToString();
            UpdateGridProducts();
        }

        private void RenewTextBoxValue()
        {
            txtProdQuantity.Text = "0";
            txtProdPrice.Text = "0";
            txtProductProfit.Text = "0";
        }

        private void RenewLabelProduct()
        {
            lblProdDesc.Text = "Descrição: ";
            lblProdID.Text = "ID: ";
            lblProdName.Text = "Nome: ";
        }
        private void UpdateGridProducts()
        {
            RenewTextBoxValue();
            RenewLabelProduct();
            dgvIncomeItems.Rows.Clear();
            foreach (var item in _incomeItems)
            {
                dgvIncomeItems.Rows.Add(item.ProductID, item.Quantity, item.UnityPrice.ToString("C2"), item.Profit.ToString() + "%");
            }
        }

        private void UpdateGrid()
        {
            dgvIncomes.Rows.Clear();
            QueryResponse<List<Income>> response = _incomeBLL.GetAll();

            if (!response.Success)
            {
                MessageBox.Show(response.Message);
                return;
            }
            _incomeGrid = new List<Income>(response.Data);

            InsertGrid(_incomeGrid);
        }

        private void InsertGrid(List<Income> incomes)
        {
            foreach (var item in incomes)
            {
                dgvIncomes.Rows.Add(item.ID, item.SupplierID, item.EntryDate.ToString("dd/MM/yyyy HH:mm"), item.TotalValue.ToString("C2", CultureInfo.CurrentCulture));
            }
        }

        private void dgvIncomes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _currentRowGrid = e.RowIndex;
        }

        private void btnIncomeSelect_Click(object sender, EventArgs e)
        {
            SelectDataGrid();
        }

        private void SelectDataGrid()
        {
            if (_currentRowGrid == -1)
                return;
            this.ClearForm();
            lblCompanyName.Text = "Razão social: ";
            lblCNPJ.Text = "CNPJ: ";
            int id = (int)dgvIncomes.Rows[_currentRowGrid].Cells[0].Value;
            QueryResponse<Income> response = _incomeBLL.GetById(id);
            if (response.Success)
            {
                GetSupplierById(response.Data.SupplierID);

                txtTotalValue.Text = response.Data.TotalValue.ToString();
                lblID.Text = id.ToString();

                GetListIncomeItems(id);
                return;
            }

            MessageBox.Show(response.Message);
        }


        private void GetListIncomeItems(int id)
        {
            QueryResponse<List<IncomeItem>> queryResponse = _incomeBLL.GetByIncomeId(id);

            foreach (IncomeItem item in queryResponse.Data)
            {

                dgvIncomeItems.Rows.Add(item.ProductID, item.Quantity, item.UnityPrice.ToString("C2"), item.Profit.ToString() + "%");
                _incomeItems.Add(item);
            }

            return;
        }
        private void GetSupplierById(int supplierID)
        {
            QueryResponse<Supplier> responseSupplier = _supplierBLL.GetById(supplierID);
            if (!responseSupplier.Success)
            {
                MessageBox.Show(responseSupplier.Message);
                return;

                
            }

            lblCompanyName.Text += responseSupplier.Data.CompanyName;
            lblCNPJ.Text += responseSupplier.Data.CNPJ.InsertMaskCNPJ();
        }

        private void dgvIncomes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectDataGrid();
        }

        private void btnProductClear_Click(object sender, EventArgs e)
        {
            this.ClearForm();
            RenewLabelProduct();
            RenewLabelSupplier();
            UpdateComponentsRegister();
        }

        private void picProductRefresh_Click(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void txtSearchIncomeBySupp_Enter(object sender, EventArgs e)
        {
            pnlProduName.EnterEvent();
        }

        private void txtSearchIncomeBySupp_Leave(object sender, EventArgs e)
        {
            pnlProduName.LeaveEvent();
        }

        private void txtProdSearchID_Enter(object sender, EventArgs e)
        {
            pnlProduID.EnterEvent();
        }

        private void txtProdSearchID_Leave(object sender, EventArgs e)
        {
            pnlProduID.LeaveEvent();
        }
    }
}
