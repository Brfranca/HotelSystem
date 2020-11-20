using Entities.DataAnnotations;
using Entities.Interface;
using System.Collections.Generic;

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

        public Product()
        {
            this.SuppliersID = new List<int>();
        }
    }
}
