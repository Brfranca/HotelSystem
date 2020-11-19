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
    public partial class FormCheckIn : Form
    {
        private CheckInBLL _checkInBLL;
        private RoomBLL _roomBLL;
        private Client _client;
        private Room _room;

        public FormCheckIn()
        {
            InitializeComponent();
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
            if (_client.ID != 0)
                SelectClient();
        }

        private void SelectClient()
        {
            txtClientName.Text = _client.Name;
            txtClientCPF.Text = _client.CPF.InsertMaskCPF();
            txtClientEmail.Text = _client.Email;
            txtClientPhone1.Text = _client.Phone1;
            lblClient.Text = "Cliente: " + Convert.ToString(_client.ID);
        }

        private void SelectRoom()
        {
            txtRoomNumber.Text = _room.Number;
            txtRoomPrice.Text = Convert.ToString(_room.PricePerDay);
            txtRoomType.Text = _room.RoomType.ToString();
            txtRoomFloor.Text = _room.RoomFloor.ToString();
            lblRoom.Text = "Quarto: " + Convert.ToString(_room.ID);
        }

        private void btnClientClear_Click(object sender, EventArgs e)
        {
            this.ClearForm();
            ClearId();
        }

        private void ClearId()
        {
            lblRoom.Text = "Quarto:";
            lblClient.Text = "Cliente:";
        }

        private void btnClientRegister_Click(object sender, EventArgs e)
        {
            CheckIn checkIn = CreateCheckIn();

            Response response = _checkInBLL.Register(checkIn);
            MessageBox.Show(response.Message);
            if (response.Success)
            {
                this.ClearForm();
                ClearId();
                _room.RoomStatus = RoomStatus.Ocupado;
                _roomBLL.Update(_room);
            }
        }
    }
}
