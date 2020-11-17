using Common;
using DataAccessLayer.Infrastructure;
using Entities;
using Entities.Enums;
using System.Collections.Generic;
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

        public QueryResponse<List<Room>> GetByStatus()
        {
            DbCommand command = DbFactory.GetCurrentCommand();
            command.CommandText = $"{_select} WHERE ROOMSTATUS != @ROOMSTATUS";
            command.Parameters.AddWithValue("@ROOMSTATUS", RoomStatus.Ocupado);

            return new DbExecuter().GetAllData<Room>(command);
        }

        public bool ExistNumber(string number, int id)
        {
            return Exist(number, id, "NUMBER");
        }
    }
}
