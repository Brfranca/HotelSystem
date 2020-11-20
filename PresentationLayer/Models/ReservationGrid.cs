using System;

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
