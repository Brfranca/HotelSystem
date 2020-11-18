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
        private int _currentRowGrid;
        private ProductBLL _productBLL;
        private SaleBLL _saleBLL;
        private Product _product;
        private List<SaleItem> _saleItems;

        public FormRegisterSale()
        {
            InitializeComponent();
            _clientBLL = new ClientBLL();
            _checkinBLL = new CheckInBLL();
            _checkIn = new CheckIn();
            _roomBLL = new RoomBLL();
            _productBLL = new ProductBLL();
            _saleBLL = new SaleBLL();
            _product = new Product();
            _saleItems = new List<SaleItem>();
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

        private void btnAddSaleItem_Click(object sender, EventArgs e)
        {
            SelectDataGrid();
            CreateSaleItem();
        }

        private void SelectDataGrid()
        {
            if (_currentRowGrid == -1)
                return;
            int id = (int)dgvProducts.Rows[_currentRowGrid].Cells[0].Value;
            QueryResponse<Product> response = _productBLL.GetById(id);
            if (!response.Success)
            {
                MessageBox.Show(response.Message);
                return;
            }
            _product.ID = response.Data.ID;
            _product.Price = response.Data.Price;
        }

        private void CreateSaleItem()
        {
            SaleItem saleItem = new SaleItem();
            Response response = _saleBLL.ValidateSaleItem(_product.ID, txtProdQuantity.Text, _product.Price);
            if (!response.Success)
            {
                MessageBox.Show(response.Message);
                return;
            }
            saleItem.ProductId = response.ProductId;
            saleItem.Quantity = response.ProductQuantity;
            saleItem.UnityPrice = response.ProductPrice;

            _saleItems.Add(saleItem);
            UpdateGridProducts();
        }
        private void UpdateGridProducts()
        {
            dgvIncomeItems.Rows.Clear();
            foreach (var item in _saleItems)
            {
                Product product = new Product
                {
                    ID = item.ProductId
                };

                dgvIncomeItems.Rows.Add(product.ID, product.Name, item.Quantity, item.UnityPrice.ToString("C2"));
            }

            UpdateToTalValue();
        }
        private void RenewTextBoxValue()
        {
            txtProdQuantity.Text = "0";
        }

        private void UpdateToTalValue()
        {
            double totalValue = 0.0;
            foreach (var item in _saleItems)
            {
                totalValue += item.UnityPrice * ((double)item.Quantity);
            }

            txtTotalValue.Text = totalValue.ToString("N2");
        }

        private void FormRegisterSale_Load(object sender, EventArgs e)
        {
            QueryResponse<List<Product>> response = _productBLL.GetAll();
            foreach (var item in response.Data)
            {
                dgvProducts.Rows.Add(item.ID, item.Name, item.Description, item.Price, item.Stock);
            }
        }

        private void btnSaleRegister_Click(object sender, EventArgs e)
        {
            Sale sale = CreateSale();
            Response response = _saleBLL.Register(sale);
            MessageBox.Show(response.Message);

            if (response.Success)
            {
                this.ClearForm();
                RenewTextBoxValue();
            }
        }

        private Sale CreateSale()
        {
            Sale sale = new Sale();

            sale.EmployeeID = FormMain.employee.ID;
            sale.SaleDate = DateTime.Now;
            sale.SaleItems = _saleItems;
            sale.ClientID = _checkIn.ClientID;
            sale.TotalValue = Convert.ToDouble(txtTotalValue.Text);
            return sale;
        }
    }
}
