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
            UpdateGrid();
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
            Client client = CreateClient();

            if (btnClientRegister.Text == "Cadastrar")
            {
                Response response = _clientBLL.Register(client);
                MessageBox.Show(response.Message);
                if (response.Success)
                {
                    FormHelper.ClearForm(this);
                    UpdateGrid();
                }
            }

            else if (btnClientRegister.Text == "Editar")
            {
                client.ID = Convert.ToInt32(lblCliIdGet.Text);
                Response response = _clientBLL.Update(client);
                MessageBox.Show(response.Message);
                btnClientRegister.Text = "Cadastrar";
                ChangeEnableTextBox();
                btnClientDelete.Visible = false;
                FormHelper.ClearForm(this);
                UpdateGrid();
            }
        }

        private void picClientRefresh_Click(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void picClientClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateGrid()
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
            QueryResponse<Client> response = _clientBLL.GetByCpf(cpf);
            txtClientCPF.Text = response.Data.CPF;
            txtClientEmail.Text = response.Data.Email;
            txtClientName.Text = response.Data.Name;
            txtClientPhone1.Text = response.Data.Phone1;
            txtClientPhone2.Text = response.Data.Phone2;
            txtClientRG.Text = response.Data.RG;
            lblCliIdGet.Text = response.Data.ID.ToString();

            ChangeEnableTextBox();
            btnClientDelete.Visible = true;
        }

        private void btnClientDelete_Click(object sender, EventArgs e)
        {
            Client client = CreateClient();
            client.ID = Convert.ToInt32(lblCliIdGet.Text);
            Response response = _clientBLL.Delete(client);
            MessageBox.Show(response.Message);
            FormHelper.ClearForm(this);
            UpdateGrid();
            ChangeEnableTextBox();
        }

        private Client CreateClient()
        {
            Client client = new Client();
            client.Name = txtClientName.Text;
            client.CPF = txtClientCPF.Text.RemoveMaskCPF();
            client.RG = txtClientRG.Text;
            client.Phone1 = txtClientPhone1.Text;
            client.Phone2 = txtClientPhone2.Text;
            client.Email = txtClientEmail.Text;
            return client;
        }

        private void btnClientClear_Click(object sender, EventArgs e)
        {
            FormHelper.ClearForm(this);
            if (btnClientRegister.Text == "Editar")
            {
                btnClientRegister.Text = "Cadastrar";
                ChangeEnableTextBox();
                btnClientDelete.Visible = false;
            }
        }

        private void ChangeEnableTextBox()
        {
            if (txtClientRG.Enabled)
            {
                txtClientRG.Enabled = false;
            }
            else
            {
                txtClientRG.Enabled = true;
            }
            if (txtClientCPF.Enabled)
            {
                txtClientCPF.Enabled = false;
            }
            else
            {
                txtClientCPF.Enabled = true;
            }
            
        }
    }
}
