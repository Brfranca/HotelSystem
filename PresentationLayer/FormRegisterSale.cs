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
    public partial class FormRegisterSale : Form
    {
        public FormRegisterSale()
        {
            InitializeComponent();
        }

        private void btnSearchCliente_Click(object sender, EventArgs e)
        {

        }

        private void txtClientCPF_TextChanged(object sender, EventArgs e)
        {

            if (txtClientCPF.Text.Length > 0)
            {
                txtClientRG.Clear();
            }
        }

        private void txtClientRG_TextChanged(object sender, EventArgs e)
        {
            if (txtClientRG.Text.Length > 0)
            {
                txtClientCPF.Clear();
            }
        }
    }
}
