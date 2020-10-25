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
    [TableName("EMPLOYEES")]
    public class Employee : IEntity<int>
    {
        [NonEditable]
        public int ID { get; set; }
        public string Name { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; }
        public EmployeeType EmployeeType { get; set; }
    }
}
