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
        private SaleBLL _saleBLL;
        private int _currentRowGrid;
        public static Sale sale;
        public FormCheckOut()
        {
            InitializeComponent();
            _checkIn = new CheckIn();
            _checkOutBLL = new CheckOutBLL();
            _clientBLL = new ClientBLL();
            _roomBLL = new RoomBLL();
            _saleBLL = new SaleBLL();
            sale = new Sale();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            CheckOut checkOut = CreateCheckOut();
            Response response = _checkOutBLL.Insert(checkOut);
            MessageBox.Show(response.Message);
            if (response.Success)
            {
                ClearLabel();
                this.ClearForm();
            }

        }

        private void btnSelectCheckIn_Click(object sender, EventArgs e)
        {
            ClearLabel();
            CreateCheckIn();
        }

        private void CreateCheckIn()
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
            UpdateSalesCheckIn();
        }

        private void UpdateSalesCheckIn()
        {
            QueryResponse<List<Sale>> response = _saleBLL.GetByClientId(_checkIn.ClientID);
            foreach (var item in response.Data)
            {
                dgvSales.Rows.Add(item.ID, item.SaleDate.ToString("dd/MM/yyyy"), item.TotalValue);
            }
        }
        private CheckOut CreateCheckOut()
        {
            CheckOut checkOut = new CheckOut();
            checkOut.CheckInID = _checkIn.ID;
            checkOut.ExitDay = dtCheckOut.Value;
            checkOut.TotalValue = Convert.ToDouble(lblTotalValueInsert.Text);
            return checkOut;
        }
        private void SelectCheckIn()
        {
            QueryResponse<Client> responseClient = _clientBLL.GetById(_checkIn.ClientID);
            QueryResponse<Room> responseRoom = _roomBLL.GetById(_checkIn.RoomID);
            lblNomeInsert.Text = responseClient.Data.Name;
            lblCPFInsert.Text = responseClient.Data.CPF.InsertMaskCPF();
            lblPhoneInsert.Text = responseClient.Data.Phone1;
            lblPrice.Text = _checkIn.RoomPrice.ToString();
            lblRoomTypeInsert.Text = responseRoom.Data.RoomType.ToString();
            lblNumberInsert.Text = responseRoom.Data.Number;
            lblTotalValueInsert.Text = _checkOutBLL.CalculateTotalValue(_checkIn, DateTime.Now).ToString();
        }

        private void btnSalesSelect_Click(object sender, EventArgs e)
        {
            SelectSale();
        }

        private void ClearLabel()
        {
            lblNomeInsert.Text = "<name>";
            lblCPFInsert.Text = "<CPF>";
            lblPhoneInsert.Text = "<phone>";
            lblPrice.Text = "<price>";
            lblRoomTypeInsert.Text = "<roomtype>";
            lblNumberInsert.Text = "<number>";
            lblTotalValueInsert.Text = "<valor>";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearForm();
            ClearLabel();
            dgvSales.Rows.Clear();
        }

        private void dgvSales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _currentRowGrid = e.RowIndex;
        }

        private void SelectSale()
        {
            if (_currentRowGrid == -1)
                return;

            int id = (int)dgvSales.Rows[_currentRowGrid].Cells[0].Value;
            QueryResponse<Sale> response = _saleBLL.GetById(id);
            if (!response.Success)
            {
                MessageBox.Show(response.Message);
                return;
            }
            sale = response.Data;
            FormSearchSale frm = new FormSearchSale();
            frm.ShowDialog();
        }
    }
}
