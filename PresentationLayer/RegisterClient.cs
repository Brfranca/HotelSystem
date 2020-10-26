using BusinessLogicalLayer;
using Common;
using Entities;
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
            client.Phone2 = txtCadCliTel1.Text;
            client.Email = txtCadCliEmail.Text;
            //ativo

            Response response = new Response();
            ClientBLL clientBLL = new ClientBLL();

            response = clientBLL.Register(client);

            MessageBox.Show(response.Message);


        }
    }
}
