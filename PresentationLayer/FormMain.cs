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

        private void lblClient_MouseHover(object sender, EventArgs e)
        {
            //fazer um metodo que recebe como parametro uma label para reutlizar no outros "MouseHover"
            lblClient.Font = new Font(lblClient.Font, FontStyle.Bold);
            lblClient.ForeColor = Color.FromArgb(246, 142, 31);
        }

        private void lblClient_MouseLeave(object sender, EventArgs e)
        {
            //fazer um metodo que recebe como parametro uma label para reutlizar no outros "MouseLeave"
            lblClient.Font = new Font(lblClient.Font, FontStyle.Regular);
            lblClient.ForeColor = Color.FromArgb(255, 255, 255);
        }
    }
}
