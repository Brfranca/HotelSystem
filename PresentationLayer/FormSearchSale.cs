using BusinessLogicalLayer.BLL;
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
    public partial class FormSearchSale : Form
    {
        private ProductBLL _productBLL;
        private SaleBLL _saleBLL;
        public FormSearchSale()
        {
            InitializeComponent();
            _productBLL = new ProductBLL();
            _saleBLL = new SaleBLL();
        }

        private void FormSearchSale_Load(object sender, EventArgs e)
        {

            QueryResponse <List<SaleItem>> responseSaleItem = _saleBLL.GetBySaleId(FormCheckOut.sale.ID);
            foreach (var item in responseSaleItem.Data)
            {
                QueryResponse<Product> response = _productBLL.GetById(item.ProductID);
                dgvSearch.Rows.Add(response.Data.Name, response.Data.Description, response.Data.Price, item.Quantity);
            }
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
