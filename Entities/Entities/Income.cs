using Entities.DataAnnotations;
using Entities.Entities;
using Entities.Interface;
using System;
using System.Collections.Generic;

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
        [NonEditable]
        public List<IncomeItem> IncomeItems { get; set; }

        public Income()
        {
            IncomeItems = new List<IncomeItem>();
        }
    }
}
