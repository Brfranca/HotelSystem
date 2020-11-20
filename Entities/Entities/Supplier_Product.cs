using Entities.DataAnnotations;

namespace Entities.Entities
{
    [TableName("SUPPLIERS_PRODUCTS")]
    public class Supplier_Product
    {
        public int SupplierID { get; set; }

        public int ProductID { get; set; }
    }
}
