using BusinessLogicalLayer.BLL;
using BusinessLogicalLayer.Extentions;
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
    public partial class FormRegisterSupplier : Form
    {
        private readonly SupplierBLL _supplierBLL;
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
            pnlSuppName.BackColor = Color.Black;
        }

        private void txtSuppSearchCNPJ_Click(object sender, EventArgs e)
        {
            pnlSuppCNPJ.BackColor = Color.FromArgb(37, 206, 15);
        }

        private void txtSuppSearchCNPJ_Leave(object sender, EventArgs e)
        {
            pnlSuppCNPJ.BackColor = Color.Black;
        }

        private void picSupplierClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    FormHelper.ClearForm(this);
                    UpdateGrid();
                }
            }
            else if (btnSupplierRegister.Text == "Editar")
            {
                supplier.ID = Convert.ToInt32(lblSupIdGet.Text);
                Response response = _supplierBLL.Update(supplier);
                MessageBox.Show(response.Message);
                btnSupplierRegister.Text = "Cadastrar";
                txtSupplierCnpj.Enabled = true;
                txtSupplierRazaoSocial.Enabled = true;
                btnSupplierDelete.Visible = false;
                FormHelper.ClearForm(this);
                UpdateGrid();
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

            foreach (var item in response.Data)
            {
                dgvSuppliers.Rows.Add(item.CompanyName, item.Phone, item.Email, item.CNPJ);
            }
        }

        private Supplier CreateSupplier()
        {
            Supplier supplier = new Supplier();
            supplier.CompanyName = txtSupplierRazaoSocial.Text;
            supplier.ContactName = txtSupplierNomeContato.Text;
            supplier.CNPJ = txtSupplierCnpj.Text.RemoveMaskCNPJ();
            supplier.Email = txtSupplierEmail.Text;
            supplier.Phone = txtSupplierTel.Text;
            return supplier;
        }

        private void dgvSuppliers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSupplierRegister.Text = "Editar";
            string cnpj = (string)dgvSuppliers.Rows[e.RowIndex].Cells[3].Value;
            QueryResponse<Supplier> response = _supplierBLL.GetByCnpj(cnpj);
            txtSupplierCnpj.Text = response.Data.CNPJ;
            txtSupplierEmail.Text = response.Data.Email;
            txtSupplierNomeContato.Text = response.Data.ContactName;
            txtSupplierRazaoSocial.Text = response.Data.CompanyName;
            txtSupplierTel.Text = response.Data.Phone;
            lblSupIdGet.Text = response.Data.ID.ToString();
            txtSupplierCnpj.Enabled = false;
            txtSupplierRazaoSocial.Enabled = false;

            btnSupplierDelete.Visible = true;
        }

        private void btnSupplierDelete_Click(object sender, EventArgs e)
        {
            Supplier supplier = CreateSupplier();
            supplier.ID = Convert.ToInt32(lblSupIdGet.Text);

            Response response = _supplierBLL.Delete(supplier);
            MessageBox.Show(response.Message);
            FormHelper.ClearForm(this);
            UpdateGrid();
            txtSupplierCnpj.Enabled = true;
            txtSupplierRazaoSocial.Enabled = true;
        }

        private void btnSupplierClear_Click(object sender, EventArgs e)
        {
            FormHelper.ClearForm(this);

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
    }
}
