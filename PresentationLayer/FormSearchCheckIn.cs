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
    public partial class FormSearchCheckIn : Form
    {
        private CheckInBLL _checkInBLL;
        private int _currentRowGrid;
        private List<CheckIn> _checkInGrid;
        private RoomBLL _roomBLL;
        private ClientBLL _clientBLL;
        public CheckIn checkIn;
        public FormSearchCheckIn()
        {
            InitializeComponent();
            _checkInBLL = new CheckInBLL();
            _roomBLL = new RoomBLL();
            _clientBLL = new ClientBLL();
            checkIn = new CheckIn();
        }

        private void UpdateGrid()
        {
            dgvSearch.Rows.Clear();
            QueryResponse<List<CheckIn>> response = _checkInBLL.GetByActiveState();

            if (!response.Success)
            {
                MessageBox.Show(response.Message);
                return;
            }
            _checkInGrid = new List<CheckIn>(response.Data);

            InsertGrid(_checkInGrid);
        }

        private void InsertGrid(List<CheckIn> checkIns)
        {
            foreach (var item in checkIns)
            {
               QueryResponse<Room> responseRoom = _roomBLL.GetById(item.RoomID);
                QueryResponse<Client> responseClient = _clientBLL.GetById(item.ClientID);
                dgvSearch.Rows.Add(item.ID, responseRoom.Data.Number, responseClient.Data.CPF.InsertMaskCPF());
            }
        }

        

        private void SelectDataGrid()
        {
            if (_currentRowGrid == -1)
                return;

            int id = (int)dgvSearch.Rows[_currentRowGrid].Cells[0].Value;
            QueryResponse<CheckIn> response = _checkInBLL.GetById(id);
            if (!response.Success)
            {
                MessageBox.Show(response.Message);
            }
            checkIn = response.Data;
            this.Close();
        }

        private void dgvSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _currentRowGrid = e.RowIndex;
        }

        private void FormSearchCheckIn_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            SelectDataGrid();
        }



        //private void txtSearchName_TextChanged(object sender, EventArgs e)
        //{
        //    FilterGrid(txtSearchRoomNumber, txtSearchCPF, x => x. ID.ToLower().Contains(txtSearchRoomNumber.Text.ToLower()));
        //}

        //private void FilterGrid(TextBox textBox, TextBox textBox1, Func<CheckIn, bool> predicate)
        //{
        //    if (textBox.Text.Length > 0)
        //    {
        //        textBox1.Clear();
        //        List<CheckIn> customerFiltered = new List<CheckIn>();
        //        customerFiltered.AddRange(_checkInGrid.Where(predicate));
        //        dgvSearch.Rows.Clear();

        //        InsertGrid(customerFiltered);
        //    }
        //    else
        //    {
        //        dgvSearch.Rows.Clear();
        //        InsertGrid(_cGrid);
        //    }
        //}

    }
}
