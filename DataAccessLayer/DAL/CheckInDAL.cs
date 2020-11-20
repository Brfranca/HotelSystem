using Common;
using DataAccessLayer.Infrastructure;
using Entities.Entities;
using System.Collections.Generic;
using System.Data.Common;

namespace DataAccessLayer.DAL
{
    public class CheckInDAL : BaseDAL<CheckIn>
    {
        //Método que recupera a lista de checkins ativos
        public QueryResponse<List<CheckIn>> GetByActiveState()
        {
            DbCommand command = DbFactory.GetCurrentCommand();
            command.CommandText = $"{_select} WHERE ACTIVE = @ACTIVE";
            command.Parameters.AddWithValue("@ACTIVE", true);

            return new DbExecuter().GetAllData<CheckIn>(command);
        }
        //Método que verifica se dado cliente já fez algum checkin
        public bool ExistClient(string clientId, int id)
        {
            return Exist(clientId, id, "CLIENTID");
        }
    }
}
