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
    public partial class FormSearchReservation : Form
    {
        public Reservation reservation;
        public FormSearchReservation()
        {
            InitializeComponent();

            reservation = new Reservation();
        }
    }
}
