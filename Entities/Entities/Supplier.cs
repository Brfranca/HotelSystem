using Entities.DataAnnotations;
using Entities.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [TableName("SUPPLIERS")]
    public class Supplier : IEntity
    {
        [NonEditable]
        public int ID { get; set; }
        public string CompanyName { get; set; }
        public string CNPJ { get; set; }
        public string ContractName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
