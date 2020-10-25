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
    [TableName("ROOMS")]
    public class Room : IEntity<int>
    {
        [NonEditable]
        public int ID { get; set; }
        public string Number { get; set; }
        public string RoomFloor { get; set; }
        public RoomType RoomType { get; set; }
        public double PricePerDay { get; set; }
    }
}
