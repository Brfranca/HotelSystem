using Entities.DataAnnotations;

namespace Entities.Entities
{
    [TableName("INCOMEITEMS")]
    public class IncomeItem
    {
        public int IncomeID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public double UnityPrice { get; set; }
        public double Profit { get; set; }
    }
}
