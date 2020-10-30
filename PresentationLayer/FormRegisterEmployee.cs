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
        public FormRegisterEmployee()
        {
            InitializeComponent();
        }

        private void txtEmployeePassword_Click(object sender, EventArgs e)
        {
            pnlEmployeePassword.BackColor = Color.FromArgb(37, 206, 15);
        }

        private void txtEmployeePassword_Leave(object sender, EventArgs e)
        {
            pnlEmployeePassword.BackColor = Color.Black;
        }

        private void txtEmployeePassword2_Click(object sender, EventArgs e)
        {
            pnlEmployeePassword2.BackColor = Color.FromArgb(37, 206, 15);
        }

        private void txtEmployeePassword2_Leave(object sender, EventArgs e)
        {
            pnlEmployeePassword2.BackColor = Color.Black;
        }

        private void FormRegisterEmployee_Load(object sender, EventArgs e)
        {

        }

        private void picBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearchName_Click(object sender, EventArgs e)
        {
            pnlEmployeeName.BackColor = Color.FromArgb(37, 206, 15);
        }

        private void txtSearchName_Leave(object sender, EventArgs e)
        {
            pnlEmployeeName.BackColor = Color.Black;
        }

        private void txtSearchCPF_Click(object sender, EventArgs e)
        {
            pnlEmployeeCPF.BackColor = Color.FromArgb(37, 206, 15);
        }

        private void txtSearchCPF_Leave(object sender, EventArgs e)
        {
            pnlEmployeeCPF.BackColor = Color.Black;
        }
    }
}
