using BusinessLogicalLayer;
using BusinessLogicalLayer.Extentions;
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
    public partial class FormCheckIn : Form
    {
        private ClientBLL _clientBLL;
        private Client _client;
        private Room _room;


        public FormCheckIn()
        {
            InitializeComponent();
            _clientBLL = new ClientBLL();
        }

        private void FormCheckIn_Load(object sender, EventArgs e)
        {

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

        }
    }
}
