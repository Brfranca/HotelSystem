using Entities.DataAnnotations;

namespace Entities.Entities
{
    [TableName("SALEITEMS")]
    public class SaleItem
    {
        public int SaleID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public double UnityPrice { get; set; }
    }
}
