using BusinessLogicalLayer.BLL;
using Common;
using Entities;
using Entities.Entities;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Timers;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FormMain : Form
    {
        public static Employee employee;
        private static ReservationBLL _reservationBLL;
        public FormMain()
        {
            InitializeComponent();
            CustomizedDesign();
            _reservationBLL = new ReservationBLL();
            System.Timers.Timer timer = new System.Timers.Timer(TimeSpan.FromMinutes(60).TotalMinutes);
            timer.AutoReset = true;
            timer.Elapsed += new System.Timers.ElapsedEventHandler(VerifyReservation);
            timer.Start();
        }
        public static void VerifyReservation(object sender, ElapsedEventArgs e)
        {
            QueryResponse<List<Reservation>> response = _reservationBLL.GetAll();
            {
                foreach (var reservation in response.Data)
                {
                    if (DateTime.Now > reservation.EntryDate)
                    {
                        reservation.Active = false;
                        _reservationBLL.Update(reservation);
                    }
                }
            }
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
            RestrictionAccess();
            HideSubMenu();
        }

        private void RestrictionAccess()
        {
            if (employee.ID == 0 || employee.EmployeeType == EmployeeType.Recepcionista)
            {
                btnProduc.Enabled = false;
                btnCheckIn.Enabled = false;
                btnCheckOut.Enabled = false;
                btnReservation.Enabled = false;
                btnSale.Enabled = false;
                btnChangePassword.Enabled = false;
            }
        }

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

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCheckOut());
            HideSubMenu();
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
