using BusinessLogicalLayer;
using BusinessLogicalLayer.BLL;
using BusinessLogicalLayer.Extentions;
using Common;
using Entities;
using Entities.Entities;
using PresentationLayer.Models;
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
    public partial class FormSearchCheckIn : Form
    {
        private List<CheckInGrid> _checkInsGrid;
        private CheckInBLL _checkInBLL;
        private int _currentRowGrid;
        private List<CheckIn> _checkIns;
        private RoomBLL _roomBLL;
        private ClientBLL _clientBLL;
        private Room _room;
        private Client _client;
        public CheckIn checkIn;
        public FormSearchCheckIn()
        {
            InitializeComponent();
            _checkInBLL = new CheckInBLL();
            _roomBLL = new RoomBLL();
            _clientBLL = new ClientBLL();
            checkIn = new CheckIn();
            _checkInsGrid = new List<CheckInGrid>();
        }

        private void UpdateGrid()
        {
            dgvSearch.Rows.Clear();
            QueryResponse<List<CheckIn>> response = _checkInBLL.GetByActiveState();

            if (!response.Success)
            {
                MessageBox.Show(response.Message);
                return;
            }
            _checkIns = new List<CheckIn>(response.Data);
            InsertCheckInGrid(_checkIns);

            InsertGrid(_checkInsGrid);
        }

        private void InsertGrid(List<CheckInGrid> checkIns)
        {
            foreach (var item in checkIns)
            {
                dgvSearch.Rows.Add
                        (
                        item.ID,
                        item.ClientName,
                        item.ClientCPF.InsertMaskCPF(),
                        item.RoomNumber,
                        item.EntryDate.ToString("d")
                        );
            }
        }

        private void InsertCheckInGrid(List<CheckIn> checkIns)
        {
            foreach (var item in checkIns)
            {
                QueryResponse<Room> responseRoom = _roomBLL.GetById(item.RoomID);
                if (!responseRoom.Success)
                {
                    MessageBox.Show(responseRoom.Message);
                    return;
                }

                QueryResponse<Client> responseClient = _clientBLL.GetById(item.ClientID);
                if (!responseClient.Success)
                {
                    MessageBox.Show(responseClient.Message);
                    return;
                }

                _checkInsGrid.Add(CreateCheckInGrid(responseClient.Data, responseRoom.Data, item));
            }
        }

        private CheckInGrid CreateCheckInGrid(Client client, Room room, CheckIn checkIn)
        {
            CheckInGrid ckGrid = new CheckInGrid();
            ckGrid.ID = checkIn.ID;
            ckGrid.ClientName = client.Name;
            ckGrid.ClientCPF = client.CPF;
            ckGrid.RoomNumber = room.Number;
            ckGrid.EntryDate = checkIn.EntryDate;

            return ckGrid;
        }

        private void SelectDataGrid()
        {
            if (_currentRowGrid == -1)
                return;

            int id = (int)dgvSearch.Rows[_currentRowGrid].Cells[0].Value;
            QueryResponse<CheckIn> response = _checkInBLL.GetById(id);
            if (!response.Success)
            {
                MessageBox.Show(response.Message);
            }
            checkIn = response.Data;

            QueryResponse<Room> responseRoom = _roomBLL.GetById(checkIn.RoomID);
            if (!responseRoom.Success)
                MessageBox.Show(responseRoom.Message);
            _room = responseRoom.Data;

            QueryResponse<Client> responseClient = _clientBLL.GetById(checkIn.ClientID);
            if (!responseClient.Success)
                MessageBox.Show(responseClient.Message);
            _client = responseClient.Data;

            this.Close();
        }

        private void FormSearchCheckIn_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            SelectDataGrid();
        }

        private void dgvSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _currentRowGrid = e.RowIndex;
        }

        private void txtSearchRoomNumber_Enter(object sender, EventArgs e)
        {
            pnlNumber.EnterEvent();
        }

        private void txtSearchRoomNumber_Leave(object sender, EventArgs e)
        {
            pnlNumber.LeaveEvent();
        }

        private void txtSearchRoomNumber_TextChanged(object sender, EventArgs e)
        {
            FilterGrid(txtSearchRoomNumber, txtSearchCPF, txtName, x => x.RoomNumber.ToString().ToLower().Contains(txtSearchRoomNumber.Text.ToLower()));
        }

        private void txtSearchCPF_TextChanged(object sender, EventArgs e)
        {
            FilterGrid(txtSearchCPF, txtSearchRoomNumber, txtName, x => x.ClientCPF.ToString().ToLower().Contains(txtSearchCPF.Text.ToLower()));
        }

        private void txtSearchCPF_Enter(object sender, EventArgs e)
        {
            pnlCpf.EnterEvent();
        }

        private void txtSearchCPF_Leave(object sender, EventArgs e)
        {
            pnlCpf.LeaveEvent();
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            pnlName.EnterEvent();
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            pnlName.LeaveEvent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            FilterGrid(txtName, txtSearchRoomNumber, txtSearchCPF, x => x.ClientName.ToString().ToLower().Contains(txtName.Text.ToLower()));
        }

        private void FilterGrid(TextBox textBox, TextBox textBox1, TextBox textBox2, Func<CheckInGrid, bool> predicate)
        {
            if (textBox.Text.Length > 0)
            {
                textBox1.Clear();
                textBox2.Clear();
                List<CheckInGrid> customerFiltered = new List<CheckInGrid>();
                customerFiltered.AddRange(_checkInsGrid.Where(predicate));
                dgvSearch.Rows.Clear();

                InsertGrid(customerFiltered);
            }
            else
            {
                dgvSearch.Rows.Clear();
                InsertGrid(_checkInsGrid);
            }
        }

        private void dgvSearch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _currentRowGrid = e.RowIndex;
            SelectDataGrid();
        }
    }
}
