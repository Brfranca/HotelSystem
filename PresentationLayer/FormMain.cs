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
        public FormMain()
        {
            InitializeComponent();
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
            //da pra criar um metodo pra transparencia
            Transparency transparency = new Transparency();
            transparency.Show();
            //----
            new FormRegisterClient().ShowDialog();
            transparency.Close();
        }

        private void lblProduct_Click(object sender, EventArgs e)
        {
            Transparency transparency = new Transparency();
            transparency.Show();
            new FormRegisterProduct().ShowDialog();
            transparency.Close();
        }

        private void pnlLeftBar_Click(object sender, EventArgs e)
        {

            Transparency transparency = new Transparency();
            transparency.Show();
            new FormRegisterRoom().ShowDialog();
            transparency.Close();
        }

        private void lblSupplier_Click(object sender, EventArgs e)
        {
            Transparency transparency = new Transparency();
            transparency.Show();
            new FormRegisterSupplier().ShowDialog();
            transparency.Close();
        }

        private void lblEmployee_Click(object sender, EventArgs e)
        {
            Transparency transparency = new Transparency();
            transparency.Show();
            new FormRegisterEmployee().ShowDialog();
            transparency.Close();
        }

        private void lblRooms_Click(object sender, EventArgs e)
        {
            Transparency transparency = new Transparency();
            transparency.Show();
            new FormRegisterRoom().ShowDialog();
            transparency.Close();
        }

        private void lblClient_MouseHover(object sender, EventArgs e)
        {
            lblClient.MouseHoverEvent();
        }

        private void lblClient_MouseLeave(object sender, EventArgs e)
        {
            lblClient.MouseLeaveEvent();
        }

        private void lblSupplier_MouseHover(object sender, EventArgs e)
        {
            lblSupplier.MouseHoverEvent();
        }

        private void lblSupplier_MouseLeave(object sender, EventArgs e)
        {
            lblSupplier.MouseLeaveEvent();
        }

        private void lblProduct_MouseHover(object sender, EventArgs e)
        {
            lblProduct.MouseHoverEvent();
        }

        private void lblProduct_MouseLeave(object sender, EventArgs e)
        {
            lblProduct.MouseLeaveEvent();
        }

        private void lblRooms_MouseHover(object sender, EventArgs e)
        {
            lblRooms.MouseHoverEvent();
        }

        private void lblRooms_MouseLeave(object sender, EventArgs e)
        {
            lblRooms.MouseLeaveEvent();
        }

        private void lblEmployee_MouseHover(object sender, EventArgs e)
        {
            lblEmployee.MouseHoverEvent();
        }

        private void lblEmployee_MouseLeave(object sender, EventArgs e)
        {
            lblEmployee.MouseLeaveEvent();
        }

        
    }
}
