using BusinessLogicalLayer;
using Common;
using Entities;
using System;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class RegisterClient : Form
    {
        public RegisterClient()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Name = txtCadCliNome.Text;
            client.CPF = txtCadCliCpf.Text;
            client.RG = txtCadCliRg.Text;
            client.Phone1 = txtCadCliTel1.Text;
            client.Phone2 = txtCadCliTel2.Text;
            client.Email = txtCadCliEmail.Text;
            //devemos acrescentar o ativo?

            ClientBLL clientBLL = new ClientBLL();

            Response response = clientBLL.Register(client);

            MessageBox.Show(response.Message);

            
        }
    }
}
