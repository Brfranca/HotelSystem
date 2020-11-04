using BusinessLogicalLayer.BLL;
using BusinessLogicalLayer.Extentions;
using Common;
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
    public partial class FormSearchSupplier : Form
    {
        private readonly SupplierBLL _supplierBLL;
        private List<Supplier> _supplierGrid;
        public List<Supplier> suppliers;
        public FormSearchSupplier()
        {
            InitializeComponent();
            _supplierBLL = new SupplierBLL();
            suppliers = new List<Supplier>();
        }

        private void FormSearchSupplier_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void UpdateGrid()
        {
            dgvSuppliersSearch.Rows.Clear();
            QueryResponse<List<Supplier>> response = _supplierBLL.GetAll();

            if (!response.Success)
            {
                MessageBox.Show(response.Message);
                return;
            }
            _supplierGrid = new List<Supplier>(response.Data);

            InsertGrid(_supplierGrid);
        }

        private void InsertGrid(List<Supplier> suppliers)
        {
            foreach (var item in suppliers)
            {
                dgvSuppliersSearch.Rows.Add(item.CompanyName, item.CNPJ.InsertMaskCNPJ());
            }
        }

        private void btnSupplierSelect_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dgvSuppliersSearch.Rows)
            {

                if ((Convert.ToBoolean(row.Cells[2].Value)))
                {
                    string cnpj = (string)dgvSuppliersSearch.Rows[row.Index].Cells[1].Value;
                    QueryResponse<Supplier> response = _supplierBLL.GetByCnpj(cnpj);
                    suppliers.Add(response.Data);
                }
            }

            this.Close();
        }

        private void picRoomClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
