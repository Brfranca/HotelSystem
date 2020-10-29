using BusinessLogicalLayer;
using Common;
using Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FormRegisterClient : Form
    {
        ClientBLL _clientBLL;

        public FormRegisterClient()
        {
            InitializeComponent();
            _clientBLL = new ClientBLL();
        }

        private void picBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClient_Register_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Name = txtCadCliNome.Text;
            client.CPF = txtCadCliCpf.Text;
            client.RG = txtCadCliRg.Text;
            client.Phone1 = txtCadCliTel1.Text;
            client.Phone2 = txtCadCliTel2.Text;
            client.Email = txtCadCliEmail.Text;
            //devemos acrescentar o ativo?

            Response response = _clientBLL.Register(client);

            MessageBox.Show(response.Message);
        }

        private void FormRegisterClient_Load(object sender, EventArgs e)
        {
            //QueryResponse<List<Client>> response = new QueryResponse<List<Client>>();
            //response = _clientBLL.GetAll();

            //foreach (var item in response.Data)
            //{
            //    dgvClients.Rows.Add(item.ID, item.Name, item.Phone1, item.Phone2);
            //}
        }
    }
}
