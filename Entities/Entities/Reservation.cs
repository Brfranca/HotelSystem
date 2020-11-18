using Entities.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    [TableName("RESERVATIONS")]
    public class Reservation
    {
        [NonEditable]
        public int ID { get; set; }
        public int ClientID { get; set; }
        public int RoomID { get; set; }
        public double RoomPrice { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public bool Active { get; set; }
    }
}
