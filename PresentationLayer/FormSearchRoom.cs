using BusinessLogicalLayer.BLL;
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
    public partial class FormSearchRoom : Form
    {
        private RoomBLL _roomBLL;
        private List<Room> _roomGrid;
        public Room room;
        private int _currentRowGrid;
        public FormSearchRoom()
        {
            InitializeComponent();
            _roomBLL = new RoomBLL();
            room = new Room();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            SelectDataGrid();
        }

        private void UpdateGrid()
        {
            dgvSearch.Rows.Clear();
            QueryResponse<List<Room>> response = _roomBLL.GetAll();

            if (!response.Success)
            {
                MessageBox.Show(response.Message);
                return;
            }
            _roomGrid = new List<Room>(response.Data);

            InsertGrid(_roomGrid);
        }

        private void InsertGrid(List<Room> room)
        {
            foreach (var item in room)
            {
                //ver o enum se precisa converter
                dgvSearch.Rows.Add(item.Number, item.RoomType, item.RoomAvailability);
            }
        }

        private void FormSearchRoom_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void SelectDataGrid()
        {
            if (_currentRowGrid == -1)
                return;

            int id = (int)dgvSearch.Rows[_currentRowGrid].Cells[0].Value;
            QueryResponse<Room> response = _roomBLL.GetById(id);
            if (!response.Success)
            {
                MessageBox.Show(response.Message);
            }
            room = response.Data;
            this.Close();
        }

        private void dgvSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _currentRowGrid = e.RowIndex;
        }

        private void txtSearchNumber_TextChanged(object sender, EventArgs e)
        {
            FilterGrid(txtSearchNumber, txtSearchType, x => x.Number.ToLower().Contains(txtSearchNumber.Text.ToLower()));
        }

        private void txtSearchType_TextChanged(object sender, EventArgs e)
        {
            //FilterGrid(txtSearchType, txtSearchNumber, x => x.RoomType.ToLower().Contains(txtSearchType.Text.ToLower()));
        }

        private void FilterGrid(TextBox textBox, TextBox textBox1, Func<Room, bool> predicate)
        {
            if (textBox.Text.Length > 0)
            {
                textBox1.Clear();
                List<Room> customerFiltered = new List<Room>();
                customerFiltered.AddRange(_roomGrid.Where(predicate));
                dgvSearch.Rows.Clear();

                InsertGrid(customerFiltered);
            }
            else
            {
                dgvSearch.Rows.Clear();
                InsertGrid(_roomGrid);
            }
        }
    }
}
