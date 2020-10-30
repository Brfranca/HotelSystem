using BusinessLogicalLayer;
using BusinessLogicalLayer.Extentions;
using Common;
using Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FormRegisterClient : Form
    {
        private readonly ClientBLL _clientBLL;
        public FormRegisterClient()
        {
            InitializeComponent();
            _clientBLL = new ClientBLL();
        }

        private void FormRegisterClient_Load(object sender, EventArgs e)
        {
            QueryResponse<List<Client>> response = _clientBLL.GetAll();
            if (!response.Success)
            {
                MessageBox.Show(response.Message);
                return;
            }
            foreach (var item in response.Data)
            {
                dgvClients.Rows.Add(item.Name, item.CPF.InsertMaskCPF(), item.Phone1, item.Email);
            }
        }

        private void txtClientSearchCPF_Click(object sender, EventArgs e)
        {
            pnlClientCPF.BackColor = Color.FromArgb(37, 206, 15);
        }

        private void txtClientSearchCPF_Leave(object sender, EventArgs e)
        {
            pnlClientCPF.BackColor = Color.Black;
        }

        private void txtClientSearchName_Click(object sender, EventArgs e)
        {
            pnlClientName.BackColor = Color.FromArgb(37, 206, 15);
        }

        private void txtClientSearchName_Leave(object sender, EventArgs e)
        {
            pnlClientName.BackColor = Color.Black;
        }

        private void btnClientRegister_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Name = txtClientName.Text;
            client.CPF = txtClientCPF.Text;
            client.RG = txtClientRG.Text;
            client.Phone1 = txtClientPhone1.Text;
            client.Phone2 = txtClientPhone2.Text;
            client.Email = txtClientEmail.Text;

            Response response = _clientBLL.Register(client);

            MessageBox.Show(response.Message);
        }

        private void picClientRefresh_Click(object sender, EventArgs e)
        {
            QueryResponse<List<Client>> response = _clientBLL.GetAll();
            if (!response.Success)
            {
                MessageBox.Show(response.Message);
                return;
            }
            foreach (var item in response.Data)
            {
                dgvClients.Rows.Add(item.Name, item.CPF.InsertMaskCPF(), item.Phone1, item.Email);
            }
        }

        private void picClientClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
