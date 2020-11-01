using BusinessLogicalLayer.BLL;
using BusinessLogicalLayer.Extentions;
using Common;
using Correios.Net;
using Entities;
using Entities.Enums;
using NcMaster;
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
        private EmployeeBLL _employeeBLL;
        private List<Employee> _employeeGrid;

        public FormRegisterEmployee()
        {
            InitializeComponent();
            _employeeBLL = new EmployeeBLL();
        }

        private void FormRegisterEmployee_Load(object sender, EventArgs e)
        {
            cboEmployeePosition.DataSource = Enum.GetValues(typeof(EmployeeType));
            UpdateGrid();

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
            employee.Password = txtEmployeePassword.Text;
            employee.EmployeeType = (EmployeeType)cboEmployeePosition.SelectedIndex;
            employee.CEP = mktEmployeeCEP.Text;
            employee.City = txtEmployeeCity.Text;
            employee.Street = txtEmployeeStreet.Text;
            employee.Number = txtEmployeeNumber.Text;
            employee.District = txtEmployeeDistrict.Text;

            Response response = _employeeBLL.Register(employee, txtEmployeePassword2.Text);

            MessageBox.Show(response.Message);
            if (response.Success)
            {
                UpdateGrid();
            }
        }

        private void UpdateGrid()
        {
            dgvEmployee.Rows.Clear();
            QueryResponse<List<Employee>> response = _employeeBLL.GetAll();

            if (!response.Success)
            {
                MessageBox.Show(response.Message);
                return;
            }
            _employeeGrid = new List<Employee>(response.Data);

            InsertGrid(_employeeGrid);
        }

        private void InsertGrid(List<Employee> employees)
        {
            foreach (var item in employees)
            {
                dgvEmployee.Rows.Add(item.Name, item.CPF.InsertMaskCPF(), item.Phone, item.Email, item.EmployeeType);
            }
        }

        private void txtEmployeeSearchName_TextChanged(object sender, EventArgs e)
        {
            if (txtEmployeeSearchName.Text.Length > 0)
            {
                txtEmployeeSearchCPF.Clear();
                List<Employee> employeeCustomerFiltered = new List<Employee>();
                employeeCustomerFiltered.AddRange(_employeeGrid.Where(x => x.Name.ToLower().Contains(txtEmployeeSearchName.Text.ToLower())));
                dgvEmployee.Rows.Clear();

                InsertGrid(employeeCustomerFiltered);
            }
            else
            {
                dgvEmployee.Rows.Clear();
                InsertGrid(_employeeGrid);
            }
        }

        private void txtEmployeeSearchCPF_TextChanged(object sender, EventArgs e)
        {
            if (txtEmployeeSearchCPF.Text.Length > 0)
            {
                txtEmployeeSearchName.Clear();
                List<Employee> employeeCustomerFiltered = new List<Employee>();
                employeeCustomerFiltered.AddRange(_employeeGrid.Where(x => x.CPF.Contains(txtEmployeeSearchCPF.Text)));
                dgvEmployee.Rows.Clear();

                InsertGrid(employeeCustomerFiltered);
            }
            else
            {
                dgvEmployee.Rows.Clear();
                InsertGrid(_employeeGrid);
            }
        }

        private void SearchCEP()
        {
            if (!string.IsNullOrWhiteSpace(mktEmployeeCEP.Text))
            {
                WebCEP webCEP = new WebCEP(mktEmployeeCEP.Text);

                txtEmployeeCity.Text = webCEP.City;
                txtEmployeeStreet.Text = webCEP.Street;
                txtEmployeeDistrict.Text = webCEP.District;
            }
        }

        private void mktEmployeeCEP_Leave(object sender, EventArgs e)
        {
            SearchCEP();
        }
    }
}
