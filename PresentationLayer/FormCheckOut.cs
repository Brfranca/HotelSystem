using BusinessLogicalLayer;
using BusinessLogicalLayer.BLL;
using BusinessLogicalLayer.Extentions;
using Common;
using Entities;
using Entities.Entities;
using Entities.Enums;
using System;
using System.Collections.Generic;
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
        private List<Sale> _sales;
        public FormCheckOut()
        {
            InitializeComponent();
            _checkOutBLL = new CheckOutBLL();
            _clientBLL = new ClientBLL();
            _roomBLL = new RoomBLL();
            _saleBLL = new SaleBLL();
            sale = new Sale();
            _checkIn = new CheckIn();
            _sales = new List<Sale>();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            CheckOut checkOut = CreateCheckOut();
            Response response = _checkOutBLL.Insert(checkOut);
            MessageBox.Show(response.Message);
            if (response.Success)
            {
                ClearLabel();
                dgvSales.Rows.Clear();
                this.ClearForm();
                UpdateRoomStatus();
            }
        }

        private void UpdateRoomStatus()
        {
            QueryResponse<Room> response = _roomBLL.GetById(_checkIn.RoomID);
            if (!response.Success)
            {
                MessageBox.Show(response.Message);
                return;
            }

            response.Data.RoomStatus = RoomStatus.Disponível;
            Response rspUpdate = _roomBLL.Update(response.Data);
            if (!rspUpdate.Success)
            {
                MessageBox.Show(rspUpdate.Message);
            }
        }

        private void btnSelectCheckIn_Click(object sender, EventArgs e)
        {
            CreateCheckIn();
        }

        private void CreateCheckIn()
        {
            ClearLabel();
            dgvSales.Rows.Clear();
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
                if (item.SaleDate >= _checkIn.EntryDate)
                {
                    _sales.Add(item);
                    foreach (var sale in _sales)
                    {
                        dgvSales.Rows.Add(sale.ID, sale.SaleDate.ToString("dd/MM/yyyy"), sale.TotalValue);
                    }
                }
            }
        }

        private CheckOut CreateCheckOut()
        {
            CheckOut checkOut = new CheckOut();
            checkOut.EmployeeID = FormLogin.employee.ID;
            checkOut.CheckInID = _checkIn.ID;
            checkOut.ExitDay = dtCheckOut.Value;
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
            lblTotalValueInsert.Text = _checkOutBLL.CalculateTotalValue(_checkIn, DateTime.Now).ToString();
        }

        private void btnSalesSelect_Click(object sender, EventArgs e)
        {
            if (_sales.Count > 0)
            {
                SelectSale();
            }
        }

        private void ClearLabel()
        {
            lblNome.Text = "Nome: ";
            lblCPF.Text = "CPF: ";
            lblPhone.Text = "Telefone: ";
            lblRoomPrice.Text = "Preço diária: R$";
            lblRoomType.Text = "Tipo de quarto: ";
            lblNumber.Text = "Número: ";
            lblTotalValueInsert.Text = "";
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

        private void dgvSales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_sales.Count > 0)
            {
                SelectSale();
            }
        }
    }
}
