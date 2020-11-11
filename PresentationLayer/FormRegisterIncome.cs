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
            dgvSearchSupplier.Rows.Clear();
            _incomeItems.Clear();
            FormSearchSupplierIncome frmSearchSupp = new FormSearchSupplierIncome();
            frmSearchSupp.ShowDialog();

            supplier = frmSearchSupp.supplier;
            if (supplier != null)
            {
                btnSelectProduct.Enabled = true;
            }

            dgvSearchSupplier.Rows.Add(supplier.CompanyName, supplier.CNPJ.InsertMaskCNPJ());
            
            
        }

        private void picSupplierClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelectProduct_Click(object sender, EventArgs e)
        {
            dgvProductsAdd.Rows.Clear();
            FormSearchProduct frmProduto = new FormSearchProduct();
            frmProduto.supplier = supplier;

            frmProduto.ShowDialog();

            _product = frmProduto.product;
            dgvProductsAdd.Rows.Add(_product.ID, _product.Name, _product.Description);
        }

        private void FormRegisterIncome_Load(object sender, EventArgs e)
        {
            btnSelectProduct.Enabled = false;
            btnIncomeDelete.Visible = false;
            UpdateGrid();
        }

        private void btnIncomeRegister_Click(object sender, EventArgs e)
        {
            Income income = CreateIncome();
            if (btnIncomeRegister.Text == "Cadastrar")
            {
                Response response = _incomeBLL.Register(income);

                
                

                MessageBox.Show(response.Message);

                if (response.Success)
                {
                    this.ClearForm();
                    dgvSearchSupplier.Rows.Clear();
                    UpdateGrid();
                }
            }
            else if (btnIncomeRegister.Text == "Editar")
            {
                income.ID = Convert.ToInt32(lblID.Text);
                Response response = _incomeBLL.Update(income);
                
                MessageBox.Show(response.Message);
                if (response.Success)
                {
                    UpdateComponentsRegister();
                    this.ClearForm();
                    dgvSearchSupplier.Rows.Clear();
                    UpdateGrid();
                }
            }
        }

        private void UpdateComponentsRegister()
        {
            btnIncomeRegister.Text = "Cadastrar";
            txtProdQuantity.Text = "0";
            txtProdPrice.Text = "0";
            btnIncomeDelete.Visible = false;
        }

        private void UpdateComponentsEdit()
        {
            btnIncomeRegister.Text = "Editar";
            btnIncomeDelete.Visible = true;
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
            foreach (DataGridViewRow row in dgvProductsAdd.Rows)
            {
                if (row.Index == -1)
                    return;

                IncomeItem incomeItem = new IncomeItem();
                incomeItem.ProductID = (int)dgvProductsAdd.Rows[row.Index].Cells[0].Value;
                incomeItem.Quantity = Convert.ToInt32(txtProdQuantity.Text);
                incomeItem.UnityPrice = Convert.ToDouble(txtProdPrice.Text);
                if (incomeItem.ProductID == 0)
                {
                    MessageBox.Show("Nenhum produto selecionado!");
                    return;
                }
                CreateList(incomeItem);
                
            }
        }

        private void CreateList(IncomeItem incomeItem)
        {
            if (incomeItem.Quantity <= 0)
            {
                MessageBox.Show("A quantidade deve ser maior que zero!");
                return;
            }
            else if (incomeItem.UnityPrice <= 0)
            {
                MessageBox.Show("O preço unitário deve ser maior que zero!");
                return;
            }
            _incomeItems.Add(incomeItem);

            double totalValue = 0.0;
            foreach (var item in _incomeItems)
            {
                totalValue += item.UnityPrice * ((double)item.Quantity);
            }
            
            txtTotalValue.Text = totalValue.ToString();
            UpdateGridProducts();
        }

        private void UpdateGridProducts()
        {
            dgvIncomeItems.Rows.Clear();
            txtProdQuantity.Text = "0";
            txtProdPrice.Text = "0";

            dgvProductsAdd.Rows.Clear();
            foreach (var item in _incomeItems)
            {
                dgvIncomeItems.Rows.Add(item.ProductID, item.Quantity, item.UnityPrice);
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

            int id = (int)dgvIncomes.Rows[_currentRowGrid].Cells[0].Value;
            QueryResponse<Income> response = _incomeBLL.GetById(id);
            if (response.Success)
            {

                QueryResponse<Supplier> responseSupplier = _supplierBLL.GetById(response.Data.SupplierID);
                dgvSearchSupplier.Rows.Add(responseSupplier.Data.CompanyName);
                txtTotalValue.Text = response.Data.TotalValue.ToString();
                lblID.Text = id.ToString();

                QueryResponse<List<IncomeItem>> queryResponse = _incomeBLL.GetByIncomeId(id);

                foreach (IncomeItem item in queryResponse.Data)
                {
                    
                    dgvIncomeItems.Rows.Add(item.ProductID, item.Quantity, item.UnityPrice);
                    _incomeItems.Add(item);
                }

                UpdateComponentsEdit();
                return;
            }
            MessageBox.Show(response.Message);
        }

        private void dgvIncomes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectDataGrid();
        }

        private void btnIncomeDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Income income = CreateIncome();
                income.ID = Convert.ToInt32(lblID.Text);
                Response response = _incomeBLL.Delete(income);
                MessageBox.Show(response.Message);
                if (response.Success)
                {
                    this.ClearForm();
                    dgvSearchSupplier.Rows.Clear();
                    UpdateGrid();
                    UpdateComponentsRegister();
                }
            }
        }
    }
}
