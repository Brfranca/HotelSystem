using BusinessLogicalLayer;
using BusinessLogicalLayer.Extentions;
using Common;
using Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FormRegisterClient : Form
    {
        private readonly ClientBLL _clientBLL;
        private List<Client> _clientGrid;
        private int _currentRowGrid;
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
                    this.ClearForm();
                    UpdateGrid();
                }
            }

            else if (btnClientRegister.Text == "Editar")
            {
                client.ID = Convert.ToInt32(lblID.Text);
                Response response = _clientBLL.Update(client);
                MessageBox.Show(response.Message);
                if (response.Success)
                {
                    UpdateComponentsRegister();
                    this.ClearForm();
                    UpdateGrid();
                }
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
            _clientGrid = new List<Client>(response.Data);

            InsertGrid(_clientGrid);
        }

        private void dgvClients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectDataGrid();
        }

        private void btnClientDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Client client = CreateClient();
                client.ID = Convert.ToInt32(lblID.Text);
                Response response = _clientBLL.Delete(client);
                MessageBox.Show(response.Message);
                if (response.Success)
                {
                    this.ClearForm();
                    UpdateGrid();
                    UpdateComponentsRegister();
                }
            }
        }

        private Client CreateClient()
        {
            Client client = new Client();
            client.Name = txtClientName.Text;
            client.CPF = txtClientCPF.Text;
            client.RG = txtClientRG.Text;
            client.Phone1 = txtClientPhone1.Text;
            client.Phone2 = txtClientPhone2.Text;
            client.Email = txtClientEmail.Text;
            return client;
        }

        private void btnClientClear_Click(object sender, EventArgs e)
        {
            this.ClearForm();
            if (btnClientRegister.Text == "Editar")
            {
                UpdateComponentsRegister();
            }
        }

        private void UpdateComponentsRegister()
        {
            btnClientRegister.Text = "Cadastrar";
            txtClientRG.Enabled = true;
            txtClientCPF.Enabled = true;
            btnClientDelete.Visible = false;
        }

        private void UpdateComponentsEdit()
        {
            btnClientRegister.Text = "Editar";
            txtClientRG.Enabled = false;
            txtClientCPF.Enabled = false;
            btnClientDelete.Visible = true;
        }

        private void SelectDataGrid()
        {
            if (_currentRowGrid == -1)
                return;

            string cpf = (string)dgvClients.Rows[_currentRowGrid].Cells[1].Value;
            QueryResponse<Client> response = _clientBLL.GetByCpf(cpf);
            if (response.Success)
            {
                txtClientCPF.Text = response.Data.CPF;
                txtClientEmail.Text = response.Data.Email;
                txtClientName.Text = response.Data.Name;
                txtClientPhone1.Text = response.Data.Phone1;
                txtClientPhone2.Text = response.Data.Phone2;
                txtClientRG.Text = response.Data.RG;
                lblID.Text = response.Data.ID.ToString();

                UpdateComponentsEdit();
                return;
            }
            MessageBox.Show(response.Message);
        }


        private void dgvClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _currentRowGrid = e.RowIndex;
        }

        private void btnClientNew_Click(object sender, EventArgs e)
        {
            SelectDataGrid();
        }

        private void FilterGrid(TextBox textBox, TextBox textBox1, Func<Client, bool> predicate)
        {
            if (textBox.Text.Length > 0)
            {
                textBox1.Clear();
                List<Client> customerFiltered = new List<Client>();
                customerFiltered.AddRange(_clientGrid.Where(predicate));
                dgvClients.Rows.Clear();

                InsertGrid(customerFiltered);
            }
            else
            {
                dgvClients.Rows.Clear();
                InsertGrid(_clientGrid);
            }
        }

        private void InsertGrid(List<Client> clients)
        {
            foreach (var item in clients)
            {
                dgvClients.Rows.Add(item.Name, item.CPF.InsertMaskCPF(), item.Phone1, item.Email);
            }
        }

        private void txtClientSearchName_TextChanged(object sender, EventArgs e)
        {
            FilterGrid(txtClientSearchName, txtClientSearchCPF, x => x.Name.ToLower().Contains(txtClientSearchName.Text.ToLower()));
        }

        private void txtClientSearchCPF_TextChanged(object sender, EventArgs e)
        {
            FilterGrid(txtClientSearchCPF, txtClientSearchName, x => x.CPF.Contains(txtClientSearchCPF.Text.ToLower()));
        }
    }
}
