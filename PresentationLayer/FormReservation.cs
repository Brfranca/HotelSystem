using BusinessLogicalLayer;
using BusinessLogicalLayer.BLL;
using BusinessLogicalLayer.Extentions;
using Common;
using Entities;
using Entities.Entities;
using Entities.Enums;
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
    public partial class FormReservation : Form
    {
        private ReservationBLL _reservationBLL;
        private RoomBLL _roomBLL;
        private Client _client;
        private Room _room;
        private Reservation _reservation;

        public FormReservation()
        {
            InitializeComponent();
            _reservationBLL = new ReservationBLL();
            _roomBLL = new RoomBLL();
        }

        private void FormReservation_Load(object sender, EventArgs e)
        {
            this.ClearForm();
        }

        private Reservation CreateReservation()
        {
            Reservation reservation = new Reservation();
            reservation.ClientID = _client.ID;
            reservation.RoomID = _room.ID;
            reservation.RoomPrice = _room.PricePerDay;
            reservation.EntryDate = dtCheckIn.Value;
            reservation.DepartureDate = dtCheckOut.Value;
            reservation.Active = true;

            return reservation;
        }

        private void btnSelectRoom_Click(object sender, EventArgs e)
        {
            FormSearchRoom frmSearchRoom = new FormSearchRoom();
            frmSearchRoom.ShowDialog();
            _room = frmSearchRoom.room;
            SelectRoom();
        }
        private void SelectRoom()
        {
            if (_room != null)
            {
                lblRoomNumber.Text = "Número: " + _room.Number;
                lblRoomPrice.Text = "Preço diária: " + _room.PricePerDay.ToString("F2");
                lblRoomType.Text = "Tipo do quarto: " + _room.RoomType.ToString();
                lblRoomFloor.Text = "Andar: " + _room.RoomFloor.ToString();
                lblRoom.Text = "Quarto: " + Convert.ToString(_room.ID);
            }
        }

        private void btnSelectClient_Click(object sender, EventArgs e)
        {
            FormSearchClient frmSearchClient = new FormSearchClient();
            frmSearchClient.ShowDialog();
            _client = frmSearchClient.client;
            if (_client.ID != 0)
                SelectClient();
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearForm();
            ClearData();
        }

        private void ClearData()
        {
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

        private void btnReservationRegister_Click(object sender, EventArgs e)
        {
            Reservation reservation = CreateReservation();
            if (btnReservationRegister.Text == "Cadastrar")
            {
                Response response = _reservationBLL.Register(reservation);
                MessageBox.Show(response.Message);
                if (response.Success)
                {
                    this.ClearForm();
                    ClearData();
                }
            }
            else if (btnReservationRegister.Text == "Editar")
            {
                reservation.ID = _reservation.ID;
                Response response = _reservationBLL.Update(reservation);
                MessageBox.Show(response.Message);
                if (response.Success)
                {
                    this.ClearForm();
                    ClearData();
                    btnReservationRegister.Text = "Cadastrar";
                    btnDelete.Visible = false;
                }
            }
        }

        private void SelectDate()
        {
            if (_reservation.ID != 0)
            {
                dtCheckIn.Value = _reservation.EntryDate;
                dtCheckOut.Value = _reservation.DepartureDate;
            }
        }
        private void ClearDate()
        {
            dtCheckIn.Value = DateTime.Now.Date;
            dtCheckOut.Value = DateTime.Now.Date;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Response response = _reservationBLL.Delete(_reservation);
            MessageBox.Show(response.Message);
            if (response.Success)
            {
                this.ClearForm();
                ClearData();
                btnReservationRegister.Text = "Cadastrar";
                btnDelete.Visible = false;
            }
        }

        private void btnSeachReservation_Click_1(object sender, EventArgs e)
        {
            FormSearchReservation frmSearchReservation = new FormSearchReservation();
            frmSearchReservation.ShowDialog();
            _reservation = frmSearchReservation.reservation;
            _room = frmSearchReservation.room;
            _client = frmSearchReservation.client;
            if (_reservation.ID == 0)
                return;
            SelectRoom();
            SelectClient();
            SelectDate();
            btnReservationRegister.Text = "Editar";
            btnDelete.Visible = true;
        }
    }
}
