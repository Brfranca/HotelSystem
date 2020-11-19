using Entities.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    [TableName("CHECKOUTS")]
    public class CheckOut
    {
        [NonEditable]
        public int ID { get; set; }
        public int CheckInID { get; set; }
        public double TotalValue { get; set; }
        public DateTime ExitDay { get; set; }
        public int EmployeeID { get; set; }
    }
}
