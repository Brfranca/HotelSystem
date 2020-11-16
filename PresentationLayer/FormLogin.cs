using BusinessLogicalLayer.BLL;
using Common;
using Entities;
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

            //Utilizei o método GetByEmail para podermos identificar o usuário e registrar o ID do mesmo na variável employeeId. Ass: kj
            QueryResponse<Employee> response = _employeeBLL.GetByEmail(txtUser.Text);
            if (result.Success && response.Data == null)
                response = new QueryResponse<Employee> { Data = new Employee { Name = "Administrador" } };
            employee = response.Data;

            if (!result.Success)
            {
                MessageBox.Show(result.GetAllMessages());
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


    }
}
