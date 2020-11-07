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
        private List<Supplier> _suppliers;
        public FormRegisterIncome()
        {
            InitializeComponent();
            _suppliers = new List<Supplier>();
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
