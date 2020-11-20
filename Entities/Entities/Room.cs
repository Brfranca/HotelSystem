using Entities.DataAnnotations;
using Entities.Enums;
using Entities.Interface;

namespace Entities
{
    [TableName("ROOMS")]
    public class Room : IEntity
    {
        [NonEditable]
        public int ID { get; set; }
        public string Number { get; set; }
        public RoomFloor RoomFloor { get; set; }
        public RoomType RoomType { get; set; }
        public double PricePerDay { get; set; }
        public RoomStatus RoomStatus { get; set; }
    }
}
