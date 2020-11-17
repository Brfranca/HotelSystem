using BusinessLogicalLayer.BLL;
using Common;
using Entities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FormLogin : Form
    {
        private readonly EmployeeBLL _employeeBLL;
        public static Employee employee;
        public FormLogin()
        {
            InitializeComponent();
            _employeeBLL = new EmployeeBLL();
            picAttencion.Visible = false;
            lblAttencion.Visible = false;
            employee = new Employee();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var result = _employeeBLL.Login(txtUser.Text, txtPassword.Text);

            QueryResponse<Employee> response = _employeeBLL.GetByEmail(txtUser.Text);
            if (result.Success && response.Data == null)
                response = new QueryResponse<Employee> { Data = new Employee { Name = "Administrador" } };
            employee = response.Data;

            if (!result.Success)
            {
                picAttencion.Visible = true;
                lblAttencion.Visible = true;
                return;
            }

            FormMain formMain = new FormMain();
            this.Hide();
            formMain.ShowDialog();
            this.Close();
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            pnlUser.EnterEvent();
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            pnlUser.LeaveEvent();
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            pnlPassword.EnterEvent();
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            pnlPassword.LeaveEvent();
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

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.DarkGray;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.Transparent;
        }
    }
}
