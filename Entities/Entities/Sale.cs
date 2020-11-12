using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Sale
    {
        public int ID { get; set; }
        public int ClientId { get; set; }
        public DateTime SaleDate { get; set; }
        public int EmployeeId { get; set; }
        public double TotalValue { get; set; }
        public List<SaleItem> SaleItems { get; set; }

        public Sale()
        {
            SaleItems = new List<SaleItem>();
        }
    }
}
