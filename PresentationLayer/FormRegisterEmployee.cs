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
    }
}
