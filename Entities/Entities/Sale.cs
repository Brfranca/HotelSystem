using Entities.DataAnnotations;
using Entities.Interface;
using System;
using System.Collections.Generic;

namespace Entities.Entities
{
    [TableName("SALES")]
    public class Sale: IEntity
    {
        [NonEditable]
        public int ID { get; set; }
        public int ClientID { get; set; }
        public DateTime SaleDate { get; set; }
        public int EmployeeID { get; set; }
        public double TotalValue { get; set; }
        [NonEditable]
        public List<SaleItem> SaleItems { get; set; }

        public Sale()
        {
            SaleItems = new List<SaleItem>();
        }
    }
}
