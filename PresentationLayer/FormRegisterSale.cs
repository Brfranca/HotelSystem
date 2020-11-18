using BusinessLogicalLayer;
using BusinessLogicalLayer.BLL;
using BusinessLogicalLayer.Extentions;
using Common;
using Entities;
using Entities.Entities;
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
    public partial class FormRegisterSale : Form
    {
        private readonly ClientBLL _clientBLL;
        private readonly CheckInBLL _checkinBLL;
        private CheckIn _checkIn;
        private RoomBLL _roomBLL;
        public FormRegisterSale()
        {
            InitializeComponent();
            _clientBLL = new ClientBLL();
            _checkinBLL = new CheckInBLL();
            _checkIn = new CheckIn();
            _roomBLL = new RoomBLL();
        }


        private void SelectCheckIn()
        {
            QueryResponse<Client> responseClient = _clientBLL.GetById(_checkIn.ClientID);
            QueryResponse<Room> responseRoom = _roomBLL.GetById(_checkIn.RoomID);
            lblName.Text += responseClient.Data.Name;
            lblCPF.Text += responseClient.Data.CPF.InsertMaskCPF();
            lblDateCheckIn.Text += _checkIn.EntryDate.ToString("dd/MM/yyyy");
            lblRoomFloor.Text += responseRoom.Data.RoomFloor;
            lblRoomNumber.Text += responseRoom.Data.Number;
        }

        private void btnSelectCheckIn_Click(object sender, EventArgs e)
        {
            FormSearchCheckIn frm = new FormSearchCheckIn();
            frm.ShowDialog();
            _checkIn = frm.checkIn;
            if (_checkIn.ID == 0)
            {
                MessageBox.Show("Nenhum checkin selecionado!");
                return;
            }
            SelectCheckIn();
        }
    }
}
