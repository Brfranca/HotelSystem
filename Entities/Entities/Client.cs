using Entities.DataAnnotations;
using Entities.Interface;

namespace Entities
{
    [TableName("CLIENTS")]
    public class Client : IEntity
    {
        [NonEditable]
        public int ID { get; set; }
        public string Name { get; set; }
        [NonEditable]
        public string CPF { get; set; }
        [NonEditable]
        public string RG { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Email { get; set; }
    }
}
