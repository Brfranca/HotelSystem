using Common;
using DataAccessLayer.Infrastructure;
using Entities;
using System.Data.Common;

namespace DataAccessLayer.DAL
{
    public class RoomDAL : BaseDAL<Room>, IEntityCRUD<Room>
    {
        public QueryResponse<Room> GetByNumber(string number)
        {
            DbCommand command = DbFactory.GetCurrentCommand();
            command.CommandText = $"{_select} WHERE NUMBER = @NUMBER";
            command.Parameters.AddWithValue("@NUMBER", number);

            return new DbExecuter().GetSingleData<Room>(command);

        }

        public bool ExistNumber(string number, int id)
        {
            return Exist(number, id, "NUMBER");
        }
    }
}
