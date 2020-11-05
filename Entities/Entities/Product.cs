using Entities.DataAnnotations;
using Entities.Enums;
using Entities.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [TableName("PRODUCTS")]
    public class Product : IEntity
    {
        [NonEditable]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        [NonEditable]
        public List<int> SuppliersID { get; set; }
        //public ProductQuantity ProductQuantity { get; set; } precisa ter quantidade na tabela produto?

        //public Product()
        //{
        //    this.SuppliersID = new List<int>();
        //}
    }
}
