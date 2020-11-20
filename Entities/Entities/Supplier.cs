using Entities.DataAnnotations;
using Entities.Interface;

namespace Entities
{
    [TableName("SUPPLIERS")]
    public class Supplier : IEntity
    {
        [NonEditable]
        public int ID { get; set; }
        public string CompanyName { get; set; }
        public string CNPJ { get; set; }
        public string ContactName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
