using Entities.DataAnnotations;
using Entities.Enums;
using Entities.Interface;

namespace Entities
{
    [TableName("EMPLOYEES")]
    public class Employee : IEntity
    {
        [NonEditable]
        public int ID { get; set; }
        public string Name { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string CEP { get; set; }
        public EmployeeType EmployeeType { get; set; }
        public string Password { get; set; }
        public bool Active { get; set; }

    }
}
