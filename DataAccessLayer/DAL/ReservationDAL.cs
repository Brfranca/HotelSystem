using Common;
using DataAccessLayer.Infrastructure;
using Entities.Entities;
using System.Collections.Generic;
using System.Data.Common;

namespace DataAccessLayer.DAL
{
    public class ReservationDAL : BaseDAL<Reservation>
    {
        public QueryResponse<List<Reservation>> GetByIdClient(int id)
        {
            DbCommand command = DbFactory.GetCurrentCommand();
            command.CommandText = $"{_select} WHERE CLIENTID = @CLIENTID";
            command.Parameters.AddWithValue("@CLIENTID", id);

            return new DbExecuter().GetAllData<Reservation>(command);
        }

        public bool ExistClient(string clientId, int id)
        {
            return Exist(clientId, id, "CLIENTID");
        }

        public QueryResponse<List<Reservation>> GetByActiveState()
        {
            DbCommand command = DbFactory.GetCurrentCommand();
            command.CommandText = $"{_select} WHERE ACTIVE = @ACTIVE";
            command.Parameters.AddWithValue("@ACTIVE", true);

            return new DbExecuter().GetAllData<Reservation>(command);
        }
    }
}
