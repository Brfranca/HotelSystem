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
            dgvSearchSupplier.Rows.Add(supplier.CompanyName);
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
        }

        private void btnIncomeRegister_Click(object sender, EventArgs e)
        {
            Income income = CreateIncome();
            if (btnIncomeRegister.Text == "Cadastrar")
            {
                Response response = _incomeBLL.Register(income);
                MessageBox.Show(response.Message);
            }
        }

        private Income CreateIncome()
        {
            FormLogin frmLogin = new FormLogin();
            Income income = new Income();

            //ADICIONEI ID DO FUNCIONÁRIO SÓ PARA TESTE, LEMBRAR DE TIRAR E PEGAR O ID AO EFETUAR O LOGIN!
            income.EmployeeID = 1;
            income.SupplierID = supplier.ID;
            income.TotalValue = Convert.ToDouble(txtTotalValue.Text);
            income.IncomeItems = _incomeItems;
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
            dgvIncomeItems.Rows.Clear();
            txtProdQuantity.Text = "0";
            txtProdPrice.Text = "0";
            UpdateGridProducts();
        }


        private void UpdateGridProducts()
        {
            dgvProductsAdd.Rows.Clear();
            foreach (var item in _incomeItems)
            {
                dgvIncomeItems.Rows.Add(item.ProductID, item.Quantity, item.UnityPrice);
            }
        }
    }
}
