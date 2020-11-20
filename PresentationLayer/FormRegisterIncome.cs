using BusinessLogicalLayer;
using BusinessLogicalLayer.BLL;
using BusinessLogicalLayer.Extentions;
using Common;
using Entities;
using Entities.Entities;
using PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FormRegisterIncome : Form
    {
        public Supplier supplier;
        private readonly IncomeBLL _incomeBLL;
        private Product _product;
        private ProductBLL _productBLL;
        private List<IncomeItem> _incomeItems;
        private List<IncomeGrid> _incomesGrid;
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
            _productBLL = new ProductBLL();
            _incomesGrid = new List<IncomeGrid>();
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
            lblCadID.Text = "ID: ";
        }

        private void CreateSupplier()
        {
            FormSearchSupplierIncome frmSearchSupp = new FormSearchSupplierIncome();
            frmSearchSupp.ShowDialog();

            supplier = frmSearchSupp.supplier;
            if (supplier.ID != 0)
            {
                btnSelectProduct.Enabled = true;
                lblCompanyName.Text += supplier.CompanyName;
                lblCNPJ.Text += supplier.CNPJ.InsertMaskCNPJ();
                lblCadID.Text += supplier.ID;
            }
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
            InsertIncomeItem();
            RenewTextBoxValue();
        }

        private IncomeItem CreateIncomeItem()
        {
            IncomeItem incomeItem = new IncomeItem();
            incomeItem.ProductID = _product.ID;
            incomeItem.Quantity = Convert.ToInt32(txtProdQuantity.Text);
            incomeItem.UnityPrice = Convert.ToDouble(txtProdPrice.Text);
            incomeItem.Profit = Convert.ToDouble(txtProductProfit.Text);

            return incomeItem;
        }
        private void InsertIncomeItem()
        {
            IncomeItem incomeItem = CreateIncomeItem();
            Response response = _incomeBLL.ValidateIncomeItem(incomeItem);
            if (!response.Success)
            {
                MessageBox.Show(response.Message);
                return;
            }
            if (_incomeItems.Any(x => x.ProductID == incomeItem.ProductID))
            {
                MessageBox.Show("Produto já adicionado. Caso queira alterar a quantidade, remova o item adicionado com dois cliques e insira o produto novamente.");
                return;
            }
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

            txtTotalValue.Text = totalValue.ToString("F2");
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
            lblProdName.Text = "Nome: ";
        }
        private void UpdateGridProducts()
        {
            RenewTextBoxValue();
            RenewLabelProduct();
            dgvIncomeItems.Rows.Clear();
            foreach (var item in _incomeItems)
            {
                QueryResponse<Product> response = _productBLL.GetById(item.ProductID);
                if (!response.Success)
                {
                    MessageBox.Show(response.Message);
                    return;
                }
                dgvIncomeItems.Rows.Add(item.ProductID, response.Data.Name, item.Quantity, item.UnityPrice.ToString("C2"), item.Profit.ToString() + "%");
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
            ConvertIncomeGrid(response.Data);
            InsertGrid(_incomesGrid);
        }

        private void ConvertIncomeGrid(List<Income> incomes)
        {
            foreach (var item in incomes)
            {
                QueryResponse<Supplier> response = _supplierBLL.GetById(item.SupplierID);
                if (!response.Success)
                {
                    MessageBox.Show(response.Message);
                    return;
                }
                _incomesGrid.Add(CreateIncomeGrid(item, response.Data));
            }
        }

        private void InsertGrid(List<IncomeGrid> incomes)
        {
            foreach (var item in incomes)
            {
                dgvIncomes.Rows.Add
                    (
                    item.ID,
                    item.SupplierName,
                    item.EntryDate.ToString("dd/MM/yyyy HH:mm"),
                    item.TotalValue.ToString("C2", CultureInfo.CurrentCulture));
            }
        }

        private IncomeGrid CreateIncomeGrid(Income income, Supplier supplier)
        {
            IncomeGrid incomeGrid = new IncomeGrid();
            incomeGrid.ID = income.ID;
            incomeGrid.SupplierName = supplier.CompanyName;
            incomeGrid.EntryDate = income.EntryDate;
            incomeGrid.TotalValue = income.TotalValue;

            return incomeGrid;
        }

        private void dgvIncomes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _currentRowGrid = e.RowIndex;
        }

        private void btnIncomeSelect_Click(object sender, EventArgs e)
        {
            SelectDataGrid();
            dgvIncomeItems.Enabled = false;
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

                txtTotalValue.Text = response.Data.TotalValue.ToString("F2");
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
                QueryResponse<Product> response = _productBLL.GetById(item.ProductID);
                if (!response.Success)
                {
                    MessageBox.Show(response.Message);
                    return;
                }
                dgvIncomeItems.Rows.Add(item.ProductID, response.Data.Name, item.Quantity, item.UnityPrice.ToString("C2"), item.Profit.ToString() + "%");
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
            dgvIncomeItems.Enabled = false;
            btnIncomeRegister.Enabled = false;
        }

        private void btnProductClear_Click(object sender, EventArgs e)
        {
            this.ClearForm();
            dgvIncomeItems.Enabled = true;
            btnIncomeRegister.Enabled = true;
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

        private void dgvIncomeItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_currentRowGrid == -1)
                return;
            int id = (int)dgvIncomeItems.Rows[_currentRowGrid].Cells[0].Value;
            RemoveItem(id);
            UpdateGridProducts();
        }

        private void RemoveItem(int id)
        {
            _incomeItems.Remove(_incomeItems.FirstOrDefault(d => d.ProductID == id));
            UpdateToTalValue();
        }

        private void dgvIncomeItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _currentRowGrid = e.RowIndex;
        }

        private void txtSearchIncomeBySupp_TextChanged(object sender, EventArgs e)
        {
            FilterGrid(txtSearchIncomeBySupp, txtProdSearchID, x => x.SupplierName.ToLower().Contains(txtSearchIncomeBySupp.Text.ToLower()));

        }

        private void txtProdSearchID_TextChanged(object sender, EventArgs e)
        {
            FilterGrid(txtProdSearchID, txtSearchIncomeBySupp, x => x.ID.ToString().ToLower().Contains(txtProdSearchID.Text.ToLower()));
        }

        private void FilterGrid(TextBox textBox, TextBox textBox1, Func<IncomeGrid, bool> predicate)
        {
            if (textBox.Text.Length > 0)
            {
                textBox1.Clear();
                List<IncomeGrid> customerFiltered = new List<IncomeGrid>();
                customerFiltered.AddRange(_incomesGrid.Where(predicate));
                dgvIncomes.Rows.Clear();

                InsertGrid(customerFiltered);
            }
            else
            {
                dgvIncomes.Rows.Clear();
                InsertGrid(_incomesGrid);
            }
        }
    }
}
