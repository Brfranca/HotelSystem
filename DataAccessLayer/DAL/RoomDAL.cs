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
        //Retorna o quarto que corresponde ao dado número
        public QueryResponse<Room> GetByNumber(string number)
        {
            DbCommand command = DbFactory.GetCurrentCommand();
            command.CommandText = $"{_select} WHERE NUMBER = @NUMBER";
            command.Parameters.AddWithValue("@NUMBER", number);

            return new DbExecuter().GetSingleData<Room>(command);
        }

        //retorna uma lista de quartos de acordo com o status

        public QueryResponse<List<Room>> GetByStatus(RoomStatus roomStatus)
        {
            DbCommand command = DbFactory.GetCurrentCommand();
            command.CommandText = $"{_select} WHERE ROOMSTATUS = @ROOMSTATUS";
            command.Parameters.AddWithValue("@ROOMSTATUS", roomStatus);

            return new DbExecuter().GetAllData<Room>(command);
        }

        //verifica se o número já foi cadastrado
        public bool ExistNumber(string number, int id)
        {
            return Exist(number, id, "NUMBER");
        }
    }
}
