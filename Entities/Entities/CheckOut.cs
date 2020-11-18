using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class CheckOut
    {
        public int CheckInID { get; set; }
        public double TotalValue { get; set; }
        public DateTime ExitDay { get; set; }
    }
}
