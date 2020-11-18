using BusinessLogicalLayer.BLL;
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
        public FormCheckOut()
        {
            InitializeComponent();
            _checkIn = new CheckIn();
            _checkOutBLL = new CheckOutBLL();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            CheckOut checkOut = new CheckOut();
            checkOut.CheckInID = _checkIn.ID;
            checkOut.ExitDay = DateTime.Now;
            checkOut.TotalValue = _checkOutBLL.CalculateTotalValue(checkOut);
        }

        private void btnSelectCheckIn_Click(object sender, EventArgs e)
        {
            //chamar o método getall do checkin
        }
    }
}
