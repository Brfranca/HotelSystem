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

        private void picBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void txtSearchName_Click(object sender, EventArgs e)
        {
            pnlSearchName.BackColor = Color.FromArgb(37, 206, 15);
        }

        private void txtSearchCPF_Click(object sender, EventArgs e)
        {
            pnlSearchCPF.BackColor = Color.FromArgb(37, 206, 15);
        }

        private void txtSearchName_Leave(object sender, EventArgs e)
        {
            pnlSearchName.BackColor = Color.Black;
        }

        private void txtSearchCPF_Leave(object sender, EventArgs e)
        {
            pnlSearchCPF.BackColor = Color.Black;
        }
    }
}
