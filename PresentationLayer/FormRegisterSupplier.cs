using BusinessLogicalLayer.BLL;
using BusinessLogicalLayer.Extentions;
using Common;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FormRegisterSupplier : Form
    {
        private readonly SupplierBLL _supplierBLL;
        private List<Supplier> _supplierGrid;
        private int _currentRowGrid;
        public FormRegisterSupplier()
        {
            InitializeComponent();
            _supplierBLL = new SupplierBLL();
        }

        private void FormRegisterSupplier_Load(object sender, EventArgs e)
        {
            UpdateGrid();
            btnSupplierDelete.Visible = false;
        }

        private void txtSuppSearchName_Click(object sender, EventArgs e)
        {
            pnlSuppName.BackColor = Color.FromArgb(37, 206, 15);
        }

        private void txtSuppSearchName_Leave(object sender, EventArgs e)
        {
            pnlSuppName.LeaveEvent();
        }

        private void txtSuppSearchCNPJ_Leave(object sender, EventArgs e)
        {
            pnlSuppCNPJ.LeaveEvent();
        }

        private void btnSupplierRegister_Click(object sender, EventArgs e)
        {
            Supplier supplier = CreateSupplier();
            if (btnSupplierRegister.Text == "Cadastrar")
            {
                Response response = _supplierBLL.Register(supplier);
                MessageBox.Show(response.Message);
                if (response.Success)
                {
                    this.ClearForm();
                    UpdateGrid();
                }
            }
            else if (btnSupplierRegister.Text == "Editar")
            {
                supplier.ID = Convert.ToInt32(lblID.Text);
                Response response = _supplierBLL.Update(supplier);
                MessageBox.Show(response.Message);
                if (true)
                {
                    UpdateComponentsRegister();
                    this.ClearForm();
                    UpdateGrid();
                }
            }
        }

        private void UpdateGrid()
        {
            dgvSuppliers.Rows.Clear();
            QueryResponse<List<Supplier>> response = _supplierBLL.GetAll();

            if (!response.Success)
            {
                MessageBox.Show(response.Message);
                return;
            }
            _supplierGrid = new List<Supplier>(response.Data);

            InsertGrid(_supplierGrid);
        }

        private Supplier CreateSupplier()
        {
            Supplier supplier = new Supplier();
            supplier.CompanyName = txtSupplierRazaoSocial.Text;
            supplier.ContactName = txtSupplierNomeContato.Text;
            supplier.CNPJ = txtSupplierCnpj.Text;
            supplier.Email = txtSupplierEmail.Text;
            supplier.Phone = txtSupplierTel.Text;
            return supplier;
        }

        private void dgvSuppliers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectDataGrid();
        }

        private void btnSupplierDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Supplier supplier = CreateSupplier();
                supplier.ID = Convert.ToInt32(lblID.Text);

                Response response = _supplierBLL.Delete(supplier);
                MessageBox.Show(response.Message);
                if (response.Success)
                {
                    this.ClearForm();
                    UpdateGrid();
                    UpdateComponentsRegister();
                }
            }
        }

        private void btnSupplierClear_Click(object sender, EventArgs e)
        {
            this.ClearForm();

            if (btnSupplierRegister.Text == "Editar")
            {
                btnSupplierRegister.Text = "Cadastrar";
                txtSupplierRazaoSocial.Enabled = true;
                txtSupplierCnpj.Enabled = true;
                btnSupplierDelete.Visible = false;
            }
        }

        private void picSupplierRefresh_Click(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void InsertGrid(List<Supplier> suppliers)
        {
            foreach (var item in suppliers)
            {
                dgvSuppliers.Rows.Add(item.CompanyName, item.CNPJ.InsertMaskCNPJ(), item.Phone, item.Email);
            }
        }

        private void SelectDataGrid()
        {
            if (_currentRowGrid == -1)
                return;

            string cnpj = (string)dgvSuppliers.Rows[_currentRowGrid].Cells[1].Value;
            QueryResponse<Supplier> response = _supplierBLL.GetByCnpj(cnpj);
            if (response.Success)
            {
                txtSupplierCnpj.Text = response.Data.CNPJ;
                txtSupplierEmail.Text = response.Data.Email;
                txtSupplierNomeContato.Text = response.Data.ContactName;
                txtSupplierRazaoSocial.Text = response.Data.CompanyName;
                txtSupplierTel.Text = response.Data.Phone;
                lblID.Text = response.Data.ID.ToString();

                UpdateComponentsEdit();
                return;
            }
            MessageBox.Show(response.Message);
        }

        private void UpdateComponentsEdit()
        {
            btnSupplierRegister.Text = "Editar";
            txtSupplierCnpj.Enabled = false;
            txtSupplierRazaoSocial.Enabled = false;
            btnSupplierDelete.Visible = true;
        }

        private void UpdateComponentsRegister()
        {
            btnSupplierRegister.Text = "Cadastrar";
            txtSupplierCnpj.Enabled = true;
            txtSupplierRazaoSocial.Enabled = true;
            btnSupplierDelete.Visible = false;
        }

        private void dgvSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _currentRowGrid = e.RowIndex;
        }

        private void btnSupplierSelect_Click(object sender, EventArgs e)
        {
            SelectDataGrid();
        }

        private void FilterGrid(TextBox textBox, TextBox textBox1, Func<Supplier, bool> predicate)
        {
            if (textBox.Text.Length > 0)
            {
                textBox1.Clear();
                List<Supplier> customerFiltered = new List<Supplier>();
                customerFiltered.AddRange(_supplierGrid.Where(predicate));
                dgvSuppliers.Rows.Clear();

                InsertGrid(customerFiltered);
            }
            else
            {
                dgvSuppliers.Rows.Clear();
                InsertGrid(_supplierGrid);
            }
        }

        private void txtSuppSearchName_TextChanged(object sender, EventArgs e)
        {
            FilterGrid(txtSuppSearchName, txtSuppSearchCNPJ, x => x.CompanyName.ToLower().Contains(txtSuppSearchName.Text.ToLower()));
        }

        private void txtSuppSearchCNPJ_TextChanged(object sender, EventArgs e)
        {
            FilterGrid(txtSuppSearchCNPJ, txtSuppSearchName, x => x.CNPJ.Contains(txtSuppSearchCNPJ.Text));
        }

        private void btnSupplierClear_Click_1(object sender, EventArgs e)
        {
            this.ClearForm();
        }

        private void txtSuppSearchName_Enter(object sender, EventArgs e)
        {
            pnlSuppName.EnterEvent();
        }

        private void txtSuppSearchCNPJ_Enter(object sender, EventArgs e)
        {
            pnlSuppCNPJ.EnterEvent();
        }
    }
}
