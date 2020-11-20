using BusinessLogicalLayer;
using BusinessLogicalLayer.Extentions;
using Common;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FormSearchClient : Form
    {
        private ClientBLL _clientBLL;
        private List<Client> _clientGrid;
        public Client client;
        private int _currentRowGrid;
        public FormSearchClient()
        {
            InitializeComponent();
            _clientBLL = new ClientBLL();
            client = new Client();
        }

        private void FormSearchClient_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void UpdateGrid()
        {
            dgvSearch.Rows.Clear();
            QueryResponse<List<Client>> response = _clientBLL.GetAll();
            if (!response.Success)
            {
                MessageBox.Show(response.Message);
                return;
            }
            _clientGrid = new List<Client>(response.Data);

            InsertGrid(_clientGrid);
        }

        private void InsertGrid(List<Client> client)
        {
            foreach (var item in client)
            {
                dgvSearch.Rows.Add(item.Name, item.CPF.InsertMaskCPF());
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            SelectDataGrid();
        }

        private void SelectDataGrid()
        {
            if (_currentRowGrid == -1)
                return;

            string cpf = (string)dgvSearch.Rows[_currentRowGrid].Cells[1].Value;
            QueryResponse<Client> response = _clientBLL.GetByCpf(cpf);
            if (!response.Success)
            {
                MessageBox.Show(response.Message);
            }
            client = response.Data;
            this.Close();
        }

        private void dgvSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _currentRowGrid = e.RowIndex;
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            FilterGrid(txtSearchName, txtSearchCPF, x => x.Name.ToLower().Contains(txtSearchName.Text.ToLower()));
        }

        private void FilterGrid(TextBox textBox, TextBox textBox1, Func<Client, bool> predicate)
        {
            if (textBox.Text.Length > 0)
            {
                textBox1.Clear();
                List<Client> customerFiltered = new List<Client>();
                customerFiltered.AddRange(_clientGrid.Where(predicate));
                dgvSearch.Rows.Clear();

                InsertGrid(customerFiltered);
            }
            else
            {
                dgvSearch.Rows.Clear();
                InsertGrid(_clientGrid);
            }
        }

        private void txtSearchCPF_TextChanged(object sender, EventArgs e)
        {
            FilterGrid(txtSearchCPF, txtSearchName, x => x.CPF.ToLower().Contains(txtSearchCPF.Text.ToLower()));
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearchName_Enter(object sender, EventArgs e)
        {
            pnlName.EnterEvent();
        }

        private void txtSearchName_Leave(object sender, EventArgs e)
        {
            pnlName.LeaveEvent();
        }

        private void txtSearchCPF_Enter(object sender, EventArgs e)
        {
            pnlCpf.EnterEvent();
        }

        private void txtSearchCPF_Leave(object sender, EventArgs e)
        {
            pnlCpf.LeaveEvent();
        }

        private void dgvSearch_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _currentRowGrid = e.RowIndex;
            SelectDataGrid();
        }
    }
}
