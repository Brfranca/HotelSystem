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
    public partial class FormRegisterIncome : Form
    {
        public Supplier supplier;
        public FormRegisterIncome()
        {
            InitializeComponent();
            supplier = new Supplier();
        }

        private void btnSelecSupp_Click(object sender, EventArgs e)
        {
            dgvSearch.Rows.Clear();
            FormSearchSupplierIncome frmSearchSupp = new FormSearchSupplierIncome();
            frmSearchSupp.ShowDialog();

            supplier = frmSearchSupp.supplier;
            if (supplier != null)
            {
                btnSelectProduct.Enabled = true;
            }
            dgvSearch.Rows.Add(supplier.CompanyName);
        }

        private void picSupplierClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelectProduct_Click(object sender, EventArgs e)
        {
            FormSearchProduct frmProduto = new FormSearchProduct();
            frmProduto.supplier = supplier;

            frmProduto.ShowDialog();
        }

        private void FormRegisterIncome_Load(object sender, EventArgs e)
        {
            btnSelectProduct.Enabled = false;
        }
    }
}
