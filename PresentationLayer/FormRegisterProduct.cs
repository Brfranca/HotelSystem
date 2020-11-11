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
    public partial class FormRegisterProduct : Form
    {
        public List<Supplier> _suppliers;
        private readonly ProductBLL _productBLL;
        private List<Product> _productGrid;
        private int _currentRowGrid;
        private SupplierBLL _supplierBLL;
        public FormRegisterProduct()
        {
            InitializeComponent();
            _productBLL = new ProductBLL();
            _suppliers = new List<Supplier>();
            _supplierBLL = new SupplierBLL();
        }

        private void btnProductRegister_Click(object sender, EventArgs e)
        {
            Product product = CreateProduct();
            if (btnProductRegister.Text == "Cadastrar")
            {
                Response response = _productBLL.Register(product);
                MessageBox.Show(response.Message);
                if (response.Success)
                {
                    this.ClearForm();
                    _suppliers.Clear();
                    UpdateGrid();
                }
            }

            else if (btnProductRegister.Text == "Editar")
            {
                product.ID = Convert.ToInt32(lblID.Text);
                
                Response response = _productBLL.Update(product);
                MessageBox.Show(response.Message);
                if (response.Success)
                {
                    UpdateComponentsRegister();
                    this.ClearForm();
                    _suppliers.Clear();
                    UpdateGrid();
                }
            }
        }

        private void UpdateComponentsRegister()
        {
            btnProductRegister.Text = "Cadastrar";
            btnProductDelete.Visible = false;
        }

        private void UpdateComponentsEdit()
        {
            btnProductRegister.Text = "Editar";
            btnProductDelete.Visible = true;
        }


        private void SelectDataGrid()
        {
            if (_currentRowGrid == -1)
                return;
            dgvSearch.Rows.Clear();
            int id = (int)dgvProducts.Rows[_currentRowGrid].Cells[0].Value;
            QueryResponse<Product> response = _productBLL.GetById(id);
            if (response.Success)
            {
                txtProductName.Text = response.Data.Name;
                txtProductDescription.Text = response.Data.Description;
                lblID.Text = response.Data.ID.ToString();
                QueryResponse<List<Supplier_Product>> queryResponse = _productBLL.GetByProductId(id);
                
                foreach (Supplier_Product item in queryResponse.Data)
                {
                    dgvSearch.Rows.Add(_supplierBLL.GetById(item.SupplierID).Data.CompanyName);
                    _suppliers.Add(_supplierBLL.GetById(item.SupplierID).Data);
                }

                UpdateComponentsEdit();
                return;
            }
            MessageBox.Show(response.Message);
        }
        private Product CreateProduct()
        {
            Product product = new Product();
            product.Name = txtProductName.Text;
            product.Description = txtProductDescription.Text;
            product.SuppliersID = _suppliers.Select(x => x.ID).ToList();


            return product;
        }

        private void UpdateGrid()
        {
            dgvProducts.Rows.Clear();
            QueryResponse<List<Product>> response = _productBLL.GetAll();

            if (!response.Success)
            {
                MessageBox.Show(response.Message);
                return;
            }
            _productGrid = new List<Product>(response.Data);

            InsertGrid(_productGrid);
        }

        private void InsertGrid(List<Product> products)
        {
            foreach (var item in products)
            {
                dgvProducts.Rows.Add(item.ID, item.Name, item.Description, item.Price, item.Stock);
            }
        }

        private void picProductRefresh_Click(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void picSupplierClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectDataGrid();
        }

        private void btnProductDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Product product = new Product();
                product.ID = Convert.ToInt32(lblID.Text);
                Response response = _productBLL.Delete(product);
                MessageBox.Show(response.Message);
                if (response.Success)
                {
                    this.ClearForm();
                    _suppliers.Clear();
                    UpdateGrid();
                    UpdateComponentsRegister();
                }
            }
        }

        private void btnProductClear_Click(object sender, EventArgs e)
        {
            this.ClearForm();
            _suppliers.Clear();
            if (btnProductRegister.Text == "Editar")
            {
                UpdateComponentsRegister();
            }
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _currentRowGrid = e.RowIndex;
        }

        private void btnProductSelect_Click(object sender, EventArgs e)
        {
            SelectDataGrid();
        }

        private void FilterGrid(TextBox textBox, TextBox textBox1, Func<Product, bool> predicate)
        {
            if (textBox.Text.Length > 0)
            {
                textBox1.Clear();
                List<Product> customerFiltered = new List<Product>();
                customerFiltered.AddRange(_productGrid.Where(predicate));
                dgvProducts.Rows.Clear();

                InsertGrid(customerFiltered);
            }
            else
            {
                dgvProducts.Rows.Clear();
                InsertGrid(_productGrid);
            }
        }

        private void txtProdSearchName_TextChanged(object sender, EventArgs e)
        {
            FilterGrid(txtProdSearchName, txtProdSearchID, x => x.Name.ToLower().Contains(txtProdSearchName.Text.ToLower()));
        }

        private void txtProdSearchID_TextChanged(object sender, EventArgs e)
        {
            FilterGrid(txtProdSearchID, txtProdSearchName, x => x.ID.ToString().Contains(txtProdSearchID.Text));
        }

        private void FormRegisterProduct_Load(object sender, EventArgs e)
        {
            UpdateGrid();
            btnProductDelete.Visible = false;
        }

        private void txtProdSearchName_Enter(object sender, EventArgs e)
        {
            pnlProduName.EnterEvent();
        }

        private void txtProdSearchName_Leave(object sender, EventArgs e)
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

        private void btnSelecSupp_Click(object sender, EventArgs e)
        {
            dgvSearch.Rows.Clear();
            FormSearchSupplier frmSearchSupp = new FormSearchSupplier();
            frmSearchSupp.ShowDialog();
            _suppliers = frmSearchSupp.suppliers; 
            foreach (var item in _suppliers)
            {
                dgvSearch.Rows.Add(item.CompanyName);
            }
            
        }

        

        
    }
}
