using BusinessLogicalLayer.BLL;
using PresentationLayer.Load;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FormLogin : Form
    {
        private readonly EmployeeBLL _employeeBLL;
        public FormLogin()
        {
            InitializeComponent();
            _employeeBLL = new EmployeeBLL();

            picAttencion.Visible = false;
            lblAttencion.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var result = Loading.Load(_employeeBLL.Login, txtUser.Text, txtPassword.Text);
            if (!result.Success)
            {
                MessageBox.Show(result.GetAllMessages());
                return;
            }

            FormRegisterClient formRegisterClient = new FormRegisterClient();
            this.Hide();
            formRegisterClient.ShowDialog();
            this.Close();
        }

        private void txtUser_Click(object sender, EventArgs e)
        {
            pnlUser.BackColor = Color.FromArgb(37, 206, 15);

        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            pnlUser.BackColor = Color.Black;
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            pnlPassword.BackColor = Color.FromArgb(37, 206, 15);
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            pnlPassword.BackColor = Color.Black;
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
                txtPassword.UseSystemPasswordChar = false;
            else
                txtPassword.UseSystemPasswordChar = true;
        }

        private void picLoginClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
