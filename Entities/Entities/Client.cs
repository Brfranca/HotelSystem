using Entities.DataAnnotations;
using Entities.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [TableName("CLIENTS")]
    public class Client : IEntity<int>
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
