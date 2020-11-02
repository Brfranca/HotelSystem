﻿using BusinessLogicalLayer.BLL;
using Common;
using Entities;
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
        private readonly ProductBLL _productBLL;
        private List<Product> _productGrid;
        private int _currentRowGrid;
        public FormRegisterProduct()
        {
            InitializeComponent();
            _productBLL = new ProductBLL();
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

            int id = (int)dgvProducts.Rows[_currentRowGrid].Cells[0].Value;
            QueryResponse<Product> response = _productBLL.GetById(id);
            if (response.Success)
            {
                txtProductName.Text = response.Data.Name;
                txtProductDescription.Text = response.Data.Description;
                lblID.Text = response.Data.ID.ToString();

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
                dgvProducts.Rows.Add(item.ID, item.Name, item.Description, item.Price);
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
                Product product = CreateProduct();
                product.ID = Convert.ToInt32(lblID.Text);
                Response response = _productBLL.Delete(product);
                MessageBox.Show(response.Message);
                if (response.Success)
                {
                    this.ClearForm();
                    UpdateGrid();
                    UpdateComponentsRegister();
                }
            }
        }

        private void btnProductClear_Click(object sender, EventArgs e)
        {
            this.ClearForm();
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

        private void txtProdSearchName_Click(object sender, EventArgs e)
        {
            pnlProduName.BackColor = Color.FromArgb(37, 206, 15);
        }

        private void txtProdSearchName_Leave(object sender, EventArgs e)
        {
            pnlProduName.BackColor = Color.Black;
        }

        private void txtProdSearchID_Click(object sender, EventArgs e)
        {
            pnlProduID.BackColor = Color.FromArgb(37, 206, 15);
        }

        private void txtProdSearchID_Leave(object sender, EventArgs e)
        {
            pnlProduID.BackColor = Color.Black;
        }
    }
}
