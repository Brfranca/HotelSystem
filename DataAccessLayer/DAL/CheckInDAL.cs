using Common;
using DataAccessLayer.Infrastructure;
using Entities.Entities;
using System.Collections.Generic;
using System.Data.Common;

namespace DataAccessLayer.DAL
{
    public class CheckInDAL : BaseDAL<CheckIn>
    {
        public QueryResponse<List<CheckIn>> GetByActiveState()
        {
            DbCommand command = DbFactory.GetCurrentCommand();
            command.CommandText = $"{_select} WHERE ACTIVE = @ACTIVE";
            command.Parameters.AddWithValue("@ACTIVE", true);

            return new DbExecuter().GetAllData<CheckIn>(command);
        }

        public bool ExistClient(string clientId, int id)
        {
            return Exist(clientId, id, "CLIENTID");
        }
    }
}
