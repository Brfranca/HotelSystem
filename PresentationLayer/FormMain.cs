using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FormMain : Form
    {
        public static Employee employee;
        public FormMain()
        {
            InitializeComponent();
            CustomizedDesign();
        }


        private void CustomizedDesign()
        {
            pnlSubClient.Visible = false;
            pnlProdSubMenu.Visible = false;
            pnlEmpSubMenu.Visible = false;
            pnlRoomSubMenu.Visible = false;
        }

        private void HideSubMenu()
        {
            if (pnlSubClient.Visible)
                pnlSubClient.Visible = false;
            if (pnlProdSubMenu.Visible)
                pnlProdSubMenu.Visible = false;
            if (pnlEmpSubMenu.Visible)
                pnlEmpSubMenu.Visible = false;
            if (pnlRoomSubMenu.Visible)
                pnlRoomSubMenu.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            employee = FormLogin.employee;
            lblEmployeeName.Text = employee.Name;

            HideSubMenu();
        }

        // CRIAR FORM DENTRO DE UM PAINEL 
        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlDisplay.Controls.Add(childForm);
            pnlDisplay.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        // CRIAR COMPONENTES EM TEMPO DE EXECUÇÃO
        Label AddLabel(int i)
        {
            Label l = new Label();
            l.Name = "Room" + i.ToString();
            l.Text = "Room" + i.ToString() + " disponível";
            l.ForeColor = Color.White;
            l.BackColor = Color.FromArgb(19, 127, 75);
            l.Font = new Font("Segoe", 10, FontStyle.Bold);
            l.Width = 250;
            l.Height = 40;
            //l.Location = new Point(start, end);
            l.TextAlign = ContentAlignment.MiddleCenter;
            l.Margin = new Padding(5);
            return l;
        }

        private void picMainClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("G");
        }

        

        private void btnProduc_MouseHover(object sender, EventArgs e)
        {
            btnProduc.MouseHoverEvent();
        }

        private void btnProduc_MouseLeave(object sender, EventArgs e)
        {
            btnProduc.MouseLeaveEvent();
        }

        private void btnEmployee_MouseHover(object sender, EventArgs e)
        {
            btnEmployee.MouseHoverEvent();
        }

        private void btnEmployee_MouseLeave(object sender, EventArgs e)
        {
            btnEmployee.MouseLeaveEvent();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlSubClient);
        }

        private void btnRegisterClient_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormRegisterClient());
            HideSubMenu();
        }

        private void btnRegisterClient_MouseHover(object sender, EventArgs e)
        {
            btnRegisterClient.MouseHoverEvent();
        }

        private void btnRegisterClient_MouseLeave(object sender, EventArgs e)
        {
            btnRegisterClient.MouseLeaveEvent();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlEmpSubMenu);
        }

        private void btnCadProd_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormRegisterProduct());
            HideSubMenu();
        }

        private void btnCadIncome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormRegisterIncome());
            HideSubMenu();
        }

        private void btnCadProd_MouseHover(object sender, EventArgs e)
        {
            btnCadProd.MouseHoverEvent();
        }

        private void btnCadProd_MouseLeave(object sender, EventArgs e)
        {
            btnCadProd.MouseLeaveEvent();
        }

        private void btnCadIncome_MouseHover(object sender, EventArgs e)
        {
            btnCadIncome.MouseHoverEvent();
        }

        private void btnCadIncome_MouseLeave(object sender, EventArgs e)
        {
            btnCadIncome.MouseLeaveEvent();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormRegisterSupplier());
            HideSubMenu();
        }

        private void btnSupplier_MouseHover(object sender, EventArgs e)
        {
            btnSupplier.MouseHoverEvent();
        }

        private void btnSupplier_MouseLeave(object sender, EventArgs e)
        {
            btnSupplier.MouseLeaveEvent();
        }

        private void btnCadEmp_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormRegisterEmployee());
            HideSubMenu();
        }

        private void btnCadEmp_MouseHover(object sender, EventArgs e)
        {
            btnCadEmp.MouseHoverEvent();
        }

        private void btnCadEmp_MouseLeave(object sender, EventArgs e)
        {
            btnCadEmp.MouseLeaveEvent();
        }

        private void btnChangePassword_MouseHover(object sender, EventArgs e)
        {
            btnChangePassword.MouseHoverEvent();
        }

        private void btnChangePassword_MouseLeave(object sender, EventArgs e)
        {
            btnChangePassword.MouseLeaveEvent();
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlRoomSubMenu);
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormRegisterSale());
            HideSubMenu();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCheckIn());
            HideSubMenu();
        }

        private void btnProduc_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlProdSubMenu);
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormChangePassword());
            HideSubMenu();
        }

        private void btnCadRoom_MouseHover(object sender, EventArgs e)
        {
            btnCadRoom.MouseHoverEvent();
        }

        private void btnCadRoom_MouseLeave(object sender, EventArgs e)
        {
            btnCadRoom.MouseLeaveEvent();
        }

        private void btnCadRoom_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormRegisterRoom());
            HideSubMenu();
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormReservation());
            HideSubMenu();
        }
    }
}
