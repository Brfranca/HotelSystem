using BusinessLogicalLayer.BLL;
using Common;
using Entities;
using Entities.Enums;
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
    public partial class FormRegisterEmployee : Form
    {
        EmployeeBLL _employeeBLL;
        public FormRegisterEmployee()
        {
            InitializeComponent();
            _employeeBLL = new EmployeeBLL();
        }

        private void FormRegisterEmployee_Load(object sender, EventArgs e)
        {

        }

        private void txtEmployeeSearchName_Click(object sender, EventArgs e)
        {
            pnlEmployeeName.BackColor = Color.FromArgb(37, 206, 15);
        }

        private void txtEmployeeSearchName_Leave(object sender, EventArgs e)
        {
            pnlEmployeeName.BackColor = Color.Black;
        }

        private void txtEmployeeSearchCPF_Click(object sender, EventArgs e)
        {
            pnlEmployeeCPF.BackColor = Color.FromArgb(37, 206, 15);
        }

        private void txtEmployeeSearchCPF_Leave(object sender, EventArgs e)
        {
            pnlEmployeeCPF.BackColor = Color.Black;
        }

        private void picEmployeeClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEmployeeRegister_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Name = txtEmployeeName.Text;
            employee.CPF = mktEmployeeCPF.Text;
            employee.RG = txtEmployeeRG.Text;
            employee.Phone = txtEmployeePhone.Text;
            employee.Email = txtEmployeeEmail.Text;
            employee.Address.CEP = mktEmployeeCEP.Text;
            employee.Address.City = txtEmployeeCity.Text;
            employee.Address.Street = txtEmployeeStreet.Text;
            employee.Address.Number = txtEmployeeNumber.Text;
            employee.Address.District = txtEmployeeDistrict.Text;
            employee.EmployeeType = (EmployeeType)cboEmployeePosition.SelectedIndex;
            employee.Password = txtEmployeePassword.Text;

            Response response = _employeeBLL.Register(employee);

            MessageBox.Show(response.Message);
        }
    }
}
