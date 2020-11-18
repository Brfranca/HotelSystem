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
    public partial class FormCheckOut : Form
    {
        private CheckIn _checkIn;
        private readonly CheckOutBLL _checkOutBLL;
        private ClientBLL _clientBLL;
        private RoomBLL _roomBLL;
        public FormCheckOut()
        {
            InitializeComponent();
            _checkIn = new CheckIn();
            _checkOutBLL = new CheckOutBLL();
            _clientBLL = new ClientBLL();
            _roomBLL = new RoomBLL();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            CheckOut checkOut = CreateCheckOut();
            Response response = _checkOutBLL.Insert(checkOut);
            MessageBox.Show(response.Message);
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
        private CheckOut CreateCheckOut()
        {
            CheckOut checkOut = new CheckOut();
            checkOut.CheckInID = _checkIn.ID;
            checkOut.ExitDay = DateTime.Now;
            checkOut.TotalValue = Convert.ToDouble(lblTotalValueInsert.Text);
            return checkOut;
        }
        private void SelectCheckIn()
        {
            QueryResponse<Client> responseClient = _clientBLL.GetById(_checkIn.ClientID);
            QueryResponse<Room> responseRoom = _roomBLL.GetById(_checkIn.RoomID);
            lblNome.Text += responseClient.Data.Name;
            lblCPF.Text += responseClient.Data.CPF.InsertMaskCPF();
            lblPhone.Text += responseClient.Data.Phone1;
            lblRoomPrice.Text += _checkIn.RoomPrice.ToString();
            lblRoomType.Text += responseRoom.Data.RoomType.ToString();
            lblNumber.Text += responseRoom.Data.Number;
            lblTotalValueInsert.Text = _checkOutBLL.CalculateTotalValue(_checkIn.ID, DateTime.Now).ToString();
        }

        private void btnSalesSelect_Click(object sender, EventArgs e)
        {

        }
    }
}
