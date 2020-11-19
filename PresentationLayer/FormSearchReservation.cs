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
    public partial class FormSearchReservation : Form
    {
        private ReservationBLL _reservationBLL;
        private RoomBLL _roomBLL;
        private ClientBLL _clientBLL;
        private List<ReservationGrid> _reservationsGrid;
        private int _currentRowGrid;
        private string filterClient;
        public Client client;
        public Room room;
        public Reservation reservation;
        public FormSearchReservation(string clientCpf = "")
        {
            InitializeComponent();
            filterClient = clientCpf;
            _reservationBLL = new ReservationBLL();
            _roomBLL = new RoomBLL();
            _clientBLL = new ClientBLL();
            _reservationsGrid = new List<ReservationGrid>();
            reservation = new Reservation();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            SelectDataGrid();
        }

        private void SelectDataGrid()
        {
            if (_currentRowGrid == -1)
                return;

            int id = (int)dgvSearch.Rows[_currentRowGrid].Cells[0].Value;
            QueryResponse<Reservation> response = _reservationBLL.GetById(id);
            if (!response.Success)
            {
                MessageBox.Show(response.Message);
            }
            reservation = response.Data;
            QueryResponse<Room> responseRoom = _roomBLL.GetById(reservation.RoomID);
            if (!responseRoom.Success)
                MessageBox.Show(responseRoom.Message);
            room = responseRoom.Data;

            QueryResponse<Client> responseClient = _clientBLL.GetById(reservation.ClientID);
            if (!responseClient.Success)
                MessageBox.Show(responseClient.Message);
            client = responseClient.Data;

            this.Close();
        }

        private void UpdateGrid()
        {
            dgvSearch.Rows.Clear();
            QueryResponse<List<Reservation>> response = _reservationBLL.GetAll();

            if (!response.Success)
            {
                MessageBox.Show(response.Message);
                return;
            }
            List<Reservation> reservations = new List<Reservation>(response.Data);
            InsertReservationGrid(reservations);

            InsertGrid(_reservationsGrid);
        }

        private void InsertReservationGrid(List<Reservation> reservations)
        {
            foreach (var item in reservations)
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

                _reservationsGrid.Add(CreateReservationGrid(responseClient.Data, responseRoom.Data, item));
            }
        }

        private ReservationGrid CreateReservationGrid(Client client, Room room, Reservation reservation)
        {
            ReservationGrid rsvGrid = new ReservationGrid();
            rsvGrid.ID = reservation.ID;
            rsvGrid.ClientName = client.Name;
            rsvGrid.ClientCPF = client.CPF;
            rsvGrid.RoomNumber = room.Number;
            rsvGrid.EntryDate = reservation.EntryDate;
            rsvGrid.DepartureDate = reservation.DepartureDate;

            return rsvGrid;
        }

        private void InsertGrid(List<ReservationGrid> reservations)
        {
            foreach (var item in reservations)
            {
                dgvSearch.Rows.Add
                        (
                        item.ID,
                        item.ClientName,
                        item.ClientCPF.InsertMaskCPF(),
                        item.RoomNumber,
                        item.EntryDate.ToString("d"),
                        item.DepartureDate.ToString("d")
                        );
            }
        }

        private void FormSearchReservation_Load(object sender, EventArgs e)
        {
            UpdateGrid();
            txtSearchCPF.Text = filterClient;
        }

        private void dgvSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _currentRowGrid = e.RowIndex;
        }

        private void dgvSearch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _currentRowGrid = e.RowIndex;
            SelectDataGrid();
        }

        private void txtSearchRoomNumber_TextChanged(object sender, EventArgs e)
        {
            FilterGrid(txtSearchRoomNumber, txtSearchCPF,txtName, x => x.RoomNumber.ToString().ToLower().Contains(txtSearchRoomNumber.Text.ToLower()));

        }

        private void txtSearchCPF_TextChanged(object sender, EventArgs e)
        {
            FilterGrid(txtSearchCPF, txtSearchRoomNumber, txtName, x => x.ClientCPF.ToString().ToLower().Contains(txtSearchCPF.Text.ToLower()));
        }

        private void FilterGrid(TextBox textBox, TextBox textBox1, TextBox textBox2, Func<ReservationGrid, bool> predicate)
        {
            if (textBox.Text.Length > 0)
            {
                textBox1.Clear();
                textBox2.Clear();
                List<ReservationGrid> customerFiltered = new List<ReservationGrid>();
                customerFiltered.AddRange(_reservationsGrid.Where(predicate));
                dgvSearch.Rows.Clear();

                InsertGrid(customerFiltered);
            }
            else
            {
                dgvSearch.Rows.Clear();
                InsertGrid(_reservationsGrid);
            }
        }

        private void txtSearchRoomNumber_Enter(object sender, EventArgs e)
        {
            pnlNumber.EnterEvent();
        }

        private void txtSearchRoomNumber_Leave(object sender, EventArgs e)
        {
            pnlNumber.LeaveEvent();
        }

        private void txtSearchCPF_Enter(object sender, EventArgs e)
        {
            pnlCpf.EnterEvent();
        }

        private void txtSearchCPF_Leave(object sender, EventArgs e)
        {
            pnlCpf.LeaveEvent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            FilterGrid(txtName, txtSearchRoomNumber, txtSearchCPF, x => x.ClientName.ToString().ToLower().Contains(txtName.Text.ToLower()));
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            pnlName.LeaveEvent();
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            pnlName.EnterEvent();
        }
    }
}
