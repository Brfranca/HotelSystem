using BusinessLogicalLayer;
using BusinessLogicalLayer.BLL;
using BusinessLogicalLayer.Extentions;
using Common;
using Entities;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
        private List<Product> _productGrid;

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
            ClearNameProduct();
        }

        private void ClearNameProduct()
        {
            lblSelectName.Text = "";
        }

        private void SelectCheckIn()
        {
            QueryResponse<Client> responseClient = _clientBLL.GetById(_checkIn.ClientID);
            QueryResponse<Room> responseRoom = _roomBLL.GetById(_checkIn.RoomID);
            lblName.Text = "Nome: " + responseClient.Data.Name;
            lblCPF.Text = "CPF: " + responseClient.Data.CPF.InsertMaskCPF();
            lblDateCheckIn.Text = "Data CheckIn: " + _checkIn.EntryDate.ToString("dd/MM/yyyy");
            lblRoomFloor.Text = "Andar: " + responseRoom.Data.RoomFloor;
            lblRoomNumber.Text = "Número do quarto: " + responseRoom.Data.Number;
        }

        private void btnSelectCheckIn_Click(object sender, EventArgs e)
        {
            FormSearchCheckIn frm = new FormSearchCheckIn();
            frm.ShowDialog();
            if (frm.checkIn.ID != 0)
            {
                _checkIn = frm.checkIn;
                SelectCheckIn();
            }
        }

        private void btnAddSaleItem_Click(object sender, EventArgs e)
        {
            InsertSaleItem();
            RenewTextBoxValue();
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
            _product = response.Data;
            lblSelectName.Text = _product.Name + " - " + _product.Description;
        }

        private SaleItem CreateSaleItem()
        {
            SaleItem saleItem = new SaleItem();
            saleItem.ProductID = _product.ID;
            saleItem.Quantity = Convert.ToInt32(txtProdQuantity.Text);
            saleItem.UnityPrice = _product.Price;

            return saleItem;
        }

        private void InsertSaleItem()
        {
            SaleItem saleItem = CreateSaleItem();
            Response response = _saleBLL.ValidateSaleItem(saleItem);
            if (!response.Success)
            {
                MessageBox.Show(response.Message);
                return;
            }
            if (_product.Stock < saleItem.Quantity)
            {
                MessageBox.Show("Estoque insuficiente.");
                return;
            }
            _saleItems.Add(saleItem);
            Console.Beep();
            ClearNameProduct();
            UpdateGridProducts();
        }
        private void UpdateGridProducts()
        {
            dgvIncomeItems.Rows.Clear();
            foreach (var item in _saleItems)
            {
                QueryResponse<Product> response = _productBLL.GetById(item.ProductID);
                if (!response.Success)
                {
                    MessageBox.Show(response.Message);
                }
                dgvIncomeItems.Rows.Add(item.ProductID, response.Data.Name, item.Quantity, item.UnityPrice.ToString("C2"));
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
            UpdateGrid();
        }
        private void UpdateGrid()
        {
            dgvProducts.Rows.Clear();
            QueryResponse<List<Product>> response = _productBLL.GetAll();

            if (!response.Success)
            {
                MessageBox.Show(response.Message);
                return;
            }
            _productGrid = new List<Product>(response.Data.Where(x => x.Stock > 0));

            InsertGrid(_productGrid);
        }
        private void InsertGrid(List<Product> products)
        {
            foreach (var item in products)
            {
                dgvProducts.Rows.Add(item.ID, item.Name, item.Description, item.Price.ToString("C2"), item.Stock);
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
                Console.Beep();
                RenewTextBoxValue();
                UpdateGrid();
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

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _currentRowGrid = e.RowIndex;
        }

        private void dgvProducts_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectDataGrid();
        }

        private void btnSelectProduct_Click(object sender, EventArgs e)
        {
            SelectDataGrid();
        }

        private void txtProdSearchName_Enter(object sender, EventArgs e)
        {
            pnlProduName.EnterEvent();
        }

        private void txtProdSearchName_Leave(object sender, EventArgs e)
        {
            pnlProduName.LeaveEvent();
        }

        private void txtProdSearchID_Enter(object sender, EventArgs e)
        {
            pnlProduID.EnterEvent();
        }

        private void txtProdSearchID_Leave(object sender, EventArgs e)
        {
            pnlProduID.LeaveEvent();
        }

        private void txtProdQuantity_Enter(object sender, EventArgs e)
        {
            pnlEntradaProdQtd.EnterEvent();
        }

        private void txtProdQuantity_Leave(object sender, EventArgs e)
        {
            pnlEntradaProdQtd.LeaveEvent();
        }

        private void txtProdSearchName_TextChanged(object sender, EventArgs e)
        {
            FilterGrid(txtProdSearchName, txtProdSearchID, x => x.Name.ToLower().Contains(txtProdSearchName.Text.ToLower()));
        }

        private void txtProdSearchID_TextChanged(object sender, EventArgs e)
        {
            FilterGrid(txtProdSearchID, txtProdSearchName, x => x.ID.ToString().ToLower().Contains(txtProdSearchID.Text.ToLower()));
        }

        private void FilterGrid(TextBox textBox, TextBox textBox1, Func<Product, bool> predicate)
        {
            if (textBox.Text.Length > 0)
            {
                textBox1.Clear();
                List<Product> customerFiltered = new List<Product>();
                customerFiltered.AddRange(_productGrid.Where(predicate));
                dgvProducts.Rows.Clear();

                InsertGrid(customerFiltered);
            }
            else
            {
                dgvProducts.Rows.Clear();
                InsertGrid(_productGrid);
            }
        }
    }
}
