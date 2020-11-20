using BusinessLogicalLayer.BLL;
using Common;
using Entities;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FormRegisterRoom : Form
    {
        private readonly RoomBLL _roomBLL;
        private int _currentRowGrid;
        private List<Room> _roomGrid;
        public FormRegisterRoom()
        {
            InitializeComponent();
            _roomBLL = new RoomBLL();
        }

        private void FormRegisterRoom_Load(object sender, EventArgs e)
        {
            cmbRoomType.DataSource = Enum.GetValues(typeof(RoomType));
            cmbFloor.DataSource = Enum.GetValues(typeof(RoomFloor));
            UpdateGrid();
            btnRoomDelete.Visible = false;
        }

        private void btnRoomRegister_Click(object sender, EventArgs e)
        {
            Room room = CreateRoom();
            if (btnRoomRegister.Text == "Cadastrar")
            {
                Response response = _roomBLL.Register(room);
                MessageBox.Show(response.Message);
                if (response.Success)
                {
                    this.ClearForm();
                    UpdateGrid();
                }
            }

            else if (btnRoomRegister.Text == "Editar")
            {
                room.ID = Convert.ToInt32(lblID.Text);
                Response response = _roomBLL.Update(room);
                MessageBox.Show(response.Message);
                if (response.Success)
                {
                    UpdateComponentsRegister();
                    this.ClearForm();
                    UpdateGrid();
                }
            }
        }

        private Room CreateRoom()
        {
            Room room = new Room();
            room.Number = txtRoomNumber.Text;
            room.RoomFloor = (RoomFloor)cmbFloor.SelectedIndex;
            room.RoomType = (RoomType)cmbRoomType.SelectedIndex;
            room.PricePerDay = Convert.ToDouble(txtRoomPrice.Text);
            room.RoomStatus = RoomStatus.Disponível;
            return room;
        }

        private void UpdateGrid()
        {
            dgvRooms.Rows.Clear();
            QueryResponse<List<Room>> response = _roomBLL.GetAll();

            if (!response.Success)
            {
                MessageBox.Show(response.Message);
                return;
            }
            _roomGrid = new List<Room>(response.Data);

            InsertGrid(_roomGrid);
        }

        private void InsertGrid(List<Room> rooms)
        {
            foreach (var item in rooms)
            {
                dgvRooms.Rows.Add(item.ID,item.Number, item.RoomFloor, item.PricePerDay, item.RoomType, item.RoomStatus.ToString());
            }
        }

        private void dgvRooms_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectDataGrid();   
        }

        private void SelectDataGrid()
        {
            if (_currentRowGrid == -1)
                return;

            string number = (string)dgvRooms.Rows[_currentRowGrid].Cells[1].Value;
            QueryResponse<Room> response = _roomBLL.GetByNumber(number);
            if (response.Success)
            {
                txtRoomNumber.Text = response.Data.Number;
                cmbFloor.Text = response.Data.RoomFloor.ToString();
                cmbRoomType.Text = response.Data.RoomType.ToString();
                txtRoomPrice.Text = response.Data.PricePerDay.ToString();
                lblID.Text = response.Data.ID.ToString();

                UpdateComponentsEdit();
                return;
            }
            MessageBox.Show(response.Message);
        }

        private void UpdateComponentsRegister()
        {
            btnRoomRegister.Text = "Cadastrar";
            cmbFloor.Enabled = true;
            btnRoomDelete.Visible = false;
        }

        private void UpdateComponentsEdit()
        {
            btnRoomRegister.Text = "Editar";
            cmbFloor.Enabled = false;
            btnRoomDelete.Visible = true;
        }

        private void btnRoomDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Room room = CreateRoom();
                room.ID = Convert.ToInt32(lblID.Text);
                Response response = _roomBLL.Delete(room);
                MessageBox.Show(response.Message);
                if (response.Success)
                {
                    this.ClearForm();
                    UpdateGrid();
                    UpdateComponentsRegister();
                }
            }
        }

        private void btnRoomClear_Click(object sender, EventArgs e)
        {
            this.ClearForm();
            if (btnRoomRegister.Text == "Editar")
            {
                UpdateComponentsRegister();
            }
        }

        private void dgvRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _currentRowGrid = e.RowIndex;
        }

        private void btnRoomSelect_Click(object sender, EventArgs e)
        {
            SelectDataGrid();
        }

        private void FilterGrid(TextBox textBox, TextBox textBox1, Func<Room, bool> predicate)
        {
            if (textBox.Text.Length > 0)
            {
                textBox1.Clear();
                List<Room> customerFiltered = new List<Room>();
                customerFiltered.AddRange(_roomGrid.Where(predicate));
                dgvRooms.Rows.Clear();

                InsertGrid(customerFiltered);
            }
            else
            {
                dgvRooms.Rows.Clear();
                InsertGrid(_roomGrid);
            }
        }

        private void FilterGrid(ComboBox cmb, TextBox textBox, TextBox textBox1, Func<Room, bool> predicate)
        {
            if (cmb.SelectedIndex != -1)
            {
                textBox.Clear();
                textBox1.Clear();
                List<Room> customerFiltered = new List<Room>();
                customerFiltered.AddRange(_roomGrid.Where(predicate));
                dgvRooms.Rows.Clear();

                InsertGrid(customerFiltered);
            }
            else
            {
                dgvRooms.Rows.Clear();
                InsertGrid(_roomGrid);
            }
        }

        private void txtRoomSearchNumber_TextChanged(object sender, EventArgs e)
        {
            FilterGrid(txtRoomSearchNumber, txtRoomSearchID, x => x.Number.ToLower().Contains(txtRoomSearchNumber.Text.ToLower()));
        }

        private void txtRoomSearchID_TextChanged(object sender, EventArgs e)
        {
            FilterGrid(txtRoomSearchID, txtRoomSearchNumber, x => x.ID.ToString().Contains(txtRoomSearchID.Text));
        }

        private void txtRoomSearchNumber_Enter(object sender, EventArgs e)
        {
            pnlSearchNumber.EnterEvent();
        }

        private void txtRoomSearchNumber_Leave(object sender, EventArgs e)
        {
            pnlSearchNumber.LeaveEvent();
        }

        private void txtRoomSearchID_Leave(object sender, EventArgs e)
        {
            pnlsearchID.LeaveEvent();
        }

        private void picRoomClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picRoomRefresh_Click(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void txtRoomSearchID_Enter(object sender, EventArgs e)
        {
            pnlsearchID.EnterEvent();
        }
    }
}
