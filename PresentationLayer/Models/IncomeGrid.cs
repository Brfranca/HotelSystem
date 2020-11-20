using System;

namespace PresentationLayer.Models
{
    public class IncomeGrid
    {
        public int ID { get; set; }
        public string SupplierName { get; set; }
        public DateTime EntryDate { get; set; }
        public double TotalValue { get; set; }
    }
}
