using BusinessLogicalLayer.BLL;
using BusinessLogicalLayer.Extentions;
using Common;
using Entities;
using Entities.Entities;
using Entities.Enums;
using System;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FormCheckIn : Form
    {
        private CheckInBLL _checkInBLL;
        private RoomBLL _roomBLL;
        private ReservationBLL _reservationBLL;
        private Client _client;
        private Room _room;
        private Reservation _reservation;

        public FormCheckIn()
        {
            InitializeComponent();

            _reservationBLL = new ReservationBLL();
            _checkInBLL = new CheckInBLL();
            _roomBLL = new RoomBLL();
        }

        private void FormCheckIn_Load(object sender, EventArgs e)
        {
            this.ClearForm();
            dtCheckIn.Value = DateTime.Now;
        }

        private CheckIn CreateCheckIn()
        {
            CheckIn checkIn = new CheckIn();
            checkIn.ClientID = _client.ID;
            checkIn.RoomID = _room.ID;
            checkIn.RoomPrice = _room.PricePerDay;
            checkIn.EntryDate = dtCheckIn.Value;
            checkIn.DepartureDate = dtCheckOut.Value;
            checkIn.Active = true;
            checkIn.EmployeeID = FormLogin.employee.ID;

            return checkIn;
        }

        private void btnSelectRoom_Click(object sender, EventArgs e)
        {
            FormSearchRoom frmSearchRoom = new FormSearchRoom();
            frmSearchRoom.ShowDialog();
            _room = frmSearchRoom.room;
            SelectRoom();
        }

        private void btnSelectClient_Click(object sender, EventArgs e)
        {
            FormSearchClient frmSearchClient = new FormSearchClient();
            frmSearchClient.ShowDialog();
            _client = frmSearchClient.client;
            for (int i = 0; i < _checkInBLL.GetByActiveState().Data.Count; i++)
            {
                if (_checkInBLL.GetByActiveState().Data[i].ClientID == _client.ID)
                {
                    MessageBox.Show("Esse cliente já efetuou o check in.");
                    return;
                }
            }

            if (_client.ID != 0)
                SelectClient();
            for (int i = 0; i < _reservationBLL.GetByActiveState().Data.Count; i++)
            {
                if (_reservationBLL.GetByActiveState().Data[i].ClientID == _client.ID)
                {
                    DialogResult result = MessageBox.Show("Você possui uma reserva, deseja fazer o check in dessa reserva?", "", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        FormSearchReservation frmSearchReservation = new FormSearchReservation(_client.CPF);
                        frmSearchReservation.ShowDialog();
                        _room = frmSearchReservation.room;
                        _client = frmSearchReservation.client;
                        _reservation = frmSearchReservation.reservation;
                        _reservation.Active = false;
                        Response response = _reservationBLL.Update(_reservation);
                        if (!response.Success)
                        {
                            MessageBox.Show(response.Message);
                            return;
                        }
                        SelectClient();
                        SelectRoom();
                        SelectDate();
                    }
                }
            }
            
            
        }

        private void SelectDate()
        {
            if (_reservation.ID != 0)
            {
                dtCheckOut.Value = _reservation.DepartureDate;
            }
        }

        private void SelectClient()
        {
            if (_client != null)
            {
                lblClientName.Text = "Nome: " + _client.Name;
                lblClientCpf.Text = "CPF: " + _client.CPF.InsertMaskCPF();
                lblClientEmail.Text = "E-mail: " + _client.Email;
                lblClientPhone.Text = "Telefone: " + _client.Phone1;
                lblClient.Text = "Cliente: " + Convert.ToString(_client.ID);
            }
        }

        private void SelectRoom()
        {
            if (_room != null)
            {
                lblRoom.Text = "Quarto: " + _room.ID;
                lblRoomNumber.Text = "Número: " + _room.Number;
                lblRoomPrice.Text = "Preço diária: " + _room.PricePerDay.ToString("F2");
                lblRoomType.Text = "Tipo do quarto: " + _room.RoomType.ToString();
                lblRoomFloor.Text = "Andar: " + _room.RoomFloor.ToString();
                lblRoom.Text = "Quarto: " + Convert.ToString(_room.ID);
            }
        }

        private void btnClientClear_Click(object sender, EventArgs e)
        {
            this.ClearForm();
            ClearData();
        }

        private void ClearData()
        {
            lblClient.Text = "Cliente: ";
            lblRoom.Text = "Quarto: ";
            lblClientName.Text = "Nome: ";
            lblClientCpf.Text = "CPF: ";
            lblClientEmail.Text = "E-mail: ";
            lblClientPhone.Text = "Telefone: ";
            lblClient.Text = "Cliente: ";
            lblRoomNumber.Text = "Número: ";
            lblRoomPrice.Text = "Preço diária: ";
            lblRoomType.Text = "Tipo do quarto: ";
            lblRoomFloor.Text = "Andar: ";
            lblRoom.Text = "Quarto: ";
            ClearDate();
        }

        private void ClearDate()
        {
            dtCheckIn.Value = DateTime.Now.Date;
            dtCheckOut.Value = DateTime.Now.Date;
        }

        private void btnClientRegister_Click(object sender, EventArgs e)
        {
            CheckIn checkIn = CreateCheckIn();

            Response response = _checkInBLL.Register(checkIn);
            MessageBox.Show(response.Message);
            if (response.Success)
            {
                this.ClearForm();
                ClearData();
                _room.RoomStatus = RoomStatus.Ocupado;
                _roomBLL.Update(_room);
            }
        }

        private void btnSeachReservation_Click(object sender, EventArgs e)
        {
            FormSearchReservation frmSearchReservation = new FormSearchReservation();
            frmSearchReservation.ShowDialog();
            _room = frmSearchReservation.room;
            _client = frmSearchReservation.client;
            _reservation = frmSearchReservation.reservation;
            SelectClient();
            SelectRoom();
            SelectDate();
        }
    }
}
