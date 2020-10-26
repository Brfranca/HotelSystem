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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            picAttencion.Visible = false;
            lblAttencion.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void picCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void chkMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrarSenha.Checked)
                txtSenha.UseSystemPasswordChar = false;
            else
                txtSenha.UseSystemPasswordChar = true;
        }
    }
}
