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
    public partial class FormChangePassword : Form
    {
        public static Employee employee;
        private readonly EmployeeBLL _employeeBLL;
        public FormChangePassword()
        {
            InitializeComponent();
            _employeeBLL = new EmployeeBLL();
        }

        private void FormChangePassword_Load(object sender, EventArgs e)
        {
            employee = FormLogin.employee;
            lblEmployeeName.Text = employee.Name;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (!(txtCurrentPass.Text.GenerateHash() == employee.Password))
            {
                MessageBox.Show("Senha atual está incorreta!");
                return;
            }
            employee.Password = txtNewPass1.Text;
            Response response = _employeeBLL.UpdatePassword(employee, txtNewPass2.Text);
            MessageBox.Show(response.Message);
            if (response.Success)
            {
                this.ClearForm();
            }
        }
    }
}
