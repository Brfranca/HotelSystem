using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Models
{
    public class ReservationGrid
    {
        public int ID { get; set; }
        public string ClientName { get; set; }
        public string ClientCPF { get; set; }
        public string RoomNumber { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime DepartureDate { get; set; }
    }
}
