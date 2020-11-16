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
            //for (int i = 0; i <= 12; i++)
            //{
            //    Label l = AddLabel(i);
            //    flpDisplay.Controls.Add(l);
            //}
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            employee = FormLogin.employee;
            lblEmployeeName.Text = employee.Name;


            //TESTE DE CRIAÇÃO DE COMPONENTES
            //int startPosition = 600;
            //int endPosition = 60;
            //for (int i = 0; i <= 25; i++)
            //{
            //    Label l = AddLabel(i);
            //    flpComponents.Controls.Add(l);
            //    //endPosition += 100;
            //}
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

        private void lblClient_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormRegisterClient());
        }


        private void lblClient_MouseHover(object sender, EventArgs e)
        {
            lblClient.MouseHoverEvent();
        }

        private void lblClient_MouseLeave(object sender, EventArgs e)
        {
            lblClient.MouseLeaveEvent();
        }

        

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCheckIn());
        }

        private void btnProduc_MouseHover(object sender, EventArgs e)
        {
            btnProduc.MouseHoverEvent();
        }

        private void btnProduc_MouseLeave(object sender, EventArgs e)
        {
            btnProduc.MouseLeaveEvent();
        }

        private void btnProduc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormProdMain());
        }

        private void btnRoom_MouseHover(object sender, EventArgs e)
        {
            btnRoom.MouseHoverEvent();
        }

        private void btnRoom_MouseLeave(object sender, EventArgs e)
        {
            btnRoom.MouseLeaveEvent();
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormRegisterRoom());
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormRegisterSupplier());
        }

        private void btnSupplier_MouseHover(object sender, EventArgs e)
        {
            btnSupplier.MouseHoverEvent();
        }

        private void btnSupplier_MouseLeave(object sender, EventArgs e)
        {
            btnSupplier.MouseLeaveEvent();
        }

        private void btnEmployee_MouseHover(object sender, EventArgs e)
        {
            btnEmployee.MouseHoverEvent();
        }

        private void btnEmployee_MouseLeave(object sender, EventArgs e)
        {
            btnEmployee.MouseLeaveEvent();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormRegisterEmployee());
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormRegisterClient());
        }

        private void btnClients_MouseHover(object sender, EventArgs e)
        {
            btnClients.MouseHoverEvent();
        }

        private void btnClients_MouseLeave(object sender, EventArgs e)
        {
            btnClients.MouseLeaveEvent();
        }
    }
}
