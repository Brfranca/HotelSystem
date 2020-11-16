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
    public partial class FormProdMain : Form
    {
        public FormProdMain()
        {
            InitializeComponent();
        }

        private void btnCadProd_Click(object sender, EventArgs e)
        {
            FormRegisterProduct form = new FormRegisterProduct();
            form.Show();
        }

        private void btnCadIncome_Click(object sender, EventArgs e)
        {
            FormRegisterIncome form = new FormRegisterIncome();
            form.Show();
        }
    }
}
