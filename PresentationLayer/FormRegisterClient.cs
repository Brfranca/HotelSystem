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
            UpDateGrid();
            btnClientDelete.Visible = false;
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
            CreateClient(client);

            if (btnClientRegister.Text == "Cadastrar")
            {
                txtClientRG.Enabled = true;
                txtClientCPF.Enabled = true;
                Response response = _clientBLL.Register(client);
                MessageBox.Show(response.Message);
                FormHelper.ClearForm(this);
                UpDateGrid();
            }

            else if (btnClientRegister.Text == "Editar")
            {
                client.ID = Convert.ToInt32(lblCliIdGet.Text);
                Response response = _clientBLL.Update(client);
                MessageBox.Show(response.Message);
                btnClientRegister.Text = "Cadastrar";
                FormHelper.ClearForm(this);
                UpDateGrid();
            }
            
        }

        private void picClientRefresh_Click(object sender, EventArgs e)
        {
            UpDateGrid();
        }

        private void picClientClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpDateGrid()
        {
            dgvClients.Rows.Clear();
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

        private void dgvClients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnClientRegister.Text = "Editar";

            string cpf = (string)dgvClients.Rows[e.RowIndex].Cells[1].Value;
            string cpfAjustado = cpf.RemoveMaskCPF();
            QueryResponse<Client> response = _clientBLL.GetByCpf(cpfAjustado);
            txtClientCPF.Text = response.Data.CPF;
            txtClientEmail.Text = response.Data.Email;
            txtClientName.Text = response.Data.Name;
            txtClientPhone1.Text = response.Data.Phone1;
            txtClientPhone2.Text = response.Data.Phone2;
            txtClientRG.Text = response.Data.RG;
            lblCliIdGet.Text = response.Data.ID.ToString();

            txtClientRG.Enabled = false;
            txtClientCPF.Enabled = false;
            btnClientDelete.Visible = true;
        }

        private void btnClientDelete_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            CreateClient(client);
            client.ID = Convert.ToInt32(lblCliIdGet.Text);
            Response response = _clientBLL.Delete(client);
            MessageBox.Show(response.Message);
            lblCliIdGet.Text = "";
            FormHelper.ClearForm(this);
            UpDateGrid();
        }

        private void CreateClient(Client client)
        {
            client.Name = txtClientName.Text;
            client.CPF = txtClientCPF.Text.RemoveMaskCPF();
            client.RG = txtClientRG.Text;
            client.Phone1 = txtClientPhone1.Text;
            client.Phone2 = txtClientPhone2.Text;
            client.Email = txtClientEmail.Text;
        }

        private void btnClientClear_Click(object sender, EventArgs e)
        {
            FormHelper.ClearForm(this);
            lblCliIdGet.Text = "";
            if (btnClientRegister.Text == "Editar")
            {
                btnClientRegister.Text = "Cadastrar";
                txtClientRG.Enabled = true;
                txtClientCPF.Enabled = true;
                btnClientDelete.Visible = false;
            }
        }
    }
}
