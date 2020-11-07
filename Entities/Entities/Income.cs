using Entities.DataAnnotations;
using Entities.Entities;
using Entities.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [TableName("INCOMES")]
    public class Income : IEntity
    {
        [NonEditable]
        public int ID { get; set; }
        public int SupplierID { get; set; }
        public DateTime EntryDate { get; set; }
        public int EmployeeID { get; set; }
        public double TotalValue { get; set; }
        public List<IncomeItem> IncomeItems { get; set; }
    }
}
