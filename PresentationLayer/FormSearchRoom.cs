using BusinessLogicalLayer.BLL;
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
        }
    }
}
