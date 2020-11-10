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
        public FormRegisterIncome()
        {
            InitializeComponent();
            supplier = new Supplier();
            _incomeBLL = new IncomeBLL();
            _product = new Product();
            _incomeItems = new List<IncomeItem>();
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
                    UpdateGrid();
                }
            }
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
            txtTotalValue.Text = _incomeItems.Sum(x => x.UnityPrice).ToString();
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
                dgvIncomes.Rows.Add(item.SupplierID, item.EmployeeID, item.EntryDate.ToString("dd/MM/yyyy HH:mm"), item.TotalValue.ToString("C2", CultureInfo.CurrentCulture));
            }
        }
    }
}
