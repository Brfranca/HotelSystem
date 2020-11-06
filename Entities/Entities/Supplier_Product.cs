using Entities.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    [TableName("SUPPLIERS_PRODUCTS")]
    public class Supplier_Product
    {
        public int SupplierID { get; set; }

        public int ProductID { get; set; }
    }
}
