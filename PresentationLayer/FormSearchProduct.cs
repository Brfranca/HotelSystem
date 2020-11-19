using BusinessLogicalLayer.BLL;
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
    public partial class FormSearchProduct : Form
    {
        private ProductBLL _productBLL;
        private List<Product> _productGrid;
        public Supplier supplier;
        public Product product;
        private int _currentRowGrid;

        public FormSearchProduct()
        {
            InitializeComponent();
            _productBLL = new ProductBLL();
            product = new Product();
        }

        private void FormSearchProduct_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void UpdateGrid()
        {
            List<Product> products = new List<Product>();
            dgvProductSearch.Rows.Clear();

            QueryResponse<List<Supplier_Product>> response = _productBLL.GetBySupplierId(supplier.ID);

            if (!response.Success)
            {
                MessageBox.Show(response.Message);
                return;
            }
            foreach (var item in response.Data)
            {
                Product product = _productBLL.GetById(item.ProductID).Data;
                products.Add(product);
            }
            if (products.Count > 0)
            {
                _productGrid = new List<Product>(products);
                InsertGrid(_productGrid);
            }
            else
            {
                MessageBox.Show("Nenhum produto cadastrado para este fornecedor!");
                this.Dispose();
            }
        }

        private void InsertGrid(List<Product> products)
        {
            foreach (var item in products)
            {
                dgvProductSearch.Rows.Add(item.ID, item.Name, item.Description);
            }
        }

        private void picProductClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProductSelect_Click(object sender, EventArgs e)
        {
            SelectDataGrid();
            
        }

        private void SelectDataGrid()
        {
            if (_currentRowGrid == -1)
                return;

            int id = (int)dgvProductSearch.Rows[_currentRowGrid].Cells[0].Value;
            QueryResponse<Product> response = _productBLL.GetById(id);
            if (!response.Success)
            {
                MessageBox.Show(response.Message);
            }
            product = response.Data;
            this.Close();
        }

        private void dgvProductSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _currentRowGrid = e.RowIndex;
        }

        private void dgvProductSearch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectDataGrid();
        }
    }
}
