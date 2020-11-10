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
        //employeeID: adicionei para guardar o id do funcionário para poder utilizá-lo para o registro de entradas e saídas. Ass: kj
        public int employeeID;
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

            //Utilizei o método GetByEmail para podermos identificar o usuário e registrar o ID do mesmo na variável employeeId. Ass: kj
            QueryResponse<Employee> response = _employeeBLL.GetByEmail(txtUser.Text);
            employeeID = response.Data.ID;
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
