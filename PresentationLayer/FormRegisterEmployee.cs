using BusinessLogicalLayer.BLL;
using BusinessLogicalLayer.Extentions;
using Common;
using Entities;
using Entities.Enums;
using NcMaster;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FormRegisterEmployee : Form
    {


        private EmployeeBLL _employeeBLL;
        private List<Employee> _employeeGrid;
        private int _currentRowGrid;

        public FormRegisterEmployee()
        {
            InitializeComponent();
            _employeeBLL = new EmployeeBLL();
        }

        private void FormRegisterEmployee_Load(object sender, EventArgs e)
        {
            cboEmployeePosition.DataSource = Enum.GetValues(typeof(EmployeeType));
            btnEmployeeDelete.Visible = false;
            UpdateGrid();
        }

        private void picEmployeeClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEmployeeRegister_Click(object sender, EventArgs e)
        {
            Employee employee = CreateEmployee();

            if (btnEmployeeRegister.Text == "Cadastrar")
            {
                Response response = _employeeBLL.Register(employee, txtEmployeePassword2.Text);
                MessageBox.Show(response.Message);
                if (response.Success)
                {
                    this.ClearForm();
                    UpdateGrid();
                }
            }
            else if (btnEmployeeRegister.Text == "Editar")
            {
                employee.ID = int.Parse(lblID.Text);
                Response response = _employeeBLL.Update(employee, txtEmployeePassword2.Text);
                MessageBox.Show(response.Message);
                if (response.Success)
                {
                    this.ClearForm();
                    UpdateComponentsRegister();
                    UpdateGrid();
                }
            }
        }

        private Employee CreateEmployee()
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
            employee.Active = chkEmployeeActive.Checked;

            return employee;
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

        private void FilterGrid(TextBox textBox, TextBox textBox1, Func<Employee, bool> predicate)
        {
            if (textBox.Text.Length > 0)
            {
                textBox1.Clear();
                List<Employee> customerFiltered = new List<Employee>();
                customerFiltered.AddRange(_employeeGrid.Where(predicate));
                dgvEmployee.Rows.Clear();

                InsertGrid(customerFiltered);
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

        private void dgvEmployee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectDataGrid();
        }

        private void SelectDataGrid()
        {
            if (_currentRowGrid == -1)
                return;

            string cpf = (string)dgvEmployee.Rows[_currentRowGrid].Cells[1].Value;
            QueryResponse<Employee> response = _employeeBLL.GetByCpf(cpf);
            if (response.Success)
            {
                mktEmployeeCPF.Text = response.Data.CPF;
                txtEmployeeEmail.Text = response.Data.Email;
                txtEmployeeName.Text = response.Data.Name;
                txtEmployeeRG.Text = response.Data.RG;
                txtEmployeePhone.Text = response.Data.Phone;
                cboEmployeePosition.SelectedIndex = (int)response.Data.EmployeeType;
                mktEmployeeCEP.Text = response.Data.CEP;
                txtEmployeeCity.Text = response.Data.City;
                txtEmployeeStreet.Text = response.Data.Street;
                txtEmployeeNumber.Text = response.Data.Number;
                txtEmployeeDistrict.Text = response.Data.District;
                lblID.Text = response.Data.ID.ToString();
                txtEmployeePassword.Text = response.Data.Password;
                txtEmployeePassword2.Text = response.Data.Password;
                chkEmployeeActive.Checked = response.Data.Active;

                UpdateComponentsEdit();
                return;
            }
            MessageBox.Show(response.Message);
        }

        private void btnEmployeeSelect_Click(object sender, EventArgs e)
        {
            SelectDataGrid();
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _currentRowGrid = e.RowIndex;
        }

        private void btnEmployeeClear_Click(object sender, EventArgs e)
        {
            this.ClearForm();
            if (btnEmployeeRegister.Text == "Editar")
            {
                UpdateComponentsRegister();
            }
        }

        private void btnEmployeeDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Employee employee = new Employee();
                employee.ID = int.Parse(lblID.Text);

                Response response = _employeeBLL.Delete(employee);
                MessageBox.Show(response.Message);

                if (response.Success)
                {
                    this.ClearForm();
                    UpdateGrid();
                    UpdateComponentsRegister();
                }
            }
        }

        private void UpdateComponentsRegister()
        {
            btnEmployeeRegister.Text = "Cadastrar";
            txtEmployeeRG.Enabled = true;
            mktEmployeeCPF.Enabled = true;
            btnEmployeeDelete.Visible = false;
            txtEmployeePassword.Enabled = true;
            txtEmployeePassword2.Enabled = true;
        }

        private void UpdateComponentsEdit()
        {
            btnEmployeeRegister.Text = "Editar";
            txtEmployeeRG.Enabled = false;
            mktEmployeeCPF.Enabled = false;
            btnEmployeeDelete.Visible = true;
            txtEmployeePassword.Enabled = false;
            txtEmployeePassword2.Enabled = false;
        }

        private void picEmployeeRefresh_Click(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void txtEmployeeSearchName_Enter(object sender, EventArgs e)
        {
            pnlEmployeeName.EnterEvent();
        }

        private void txtEmployeeSearchCPF_Leave(object sender, EventArgs e)
        {
            pnlEmployeeCPF.LeaveEvent();
        }

        private void txtEmployeeSearchCPF_Enter(object sender, EventArgs e)
        {
            pnlEmployeeCPF.EnterEvent();
        }

        private void txtEmployeeSearchName_Leave(object sender, EventArgs e)
        {
            pnlEmployeeName.LeaveEvent();
        }

        private void txtEmployeeSearchName_TextChanged(object sender, EventArgs e)
        {
            FilterGrid(txtEmployeeSearchName, txtEmployeeSearchCPF, x => x.Name.ToLower().Contains(txtEmployeeSearchName.Text.ToLower()));
        }

        private void txtEmployeeSearchCPF_TextChanged(object sender, EventArgs e)
        {
            FilterGrid(txtEmployeeSearchCPF, txtEmployeeSearchName, x => x.CPF.Contains(txtEmployeeSearchCPF.Text));
        }
    }
}
