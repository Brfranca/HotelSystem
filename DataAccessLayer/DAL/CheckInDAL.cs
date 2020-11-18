using Common;
using DataAccessLayer.Infrastructure;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DAL
{
    //Usar interface??
    public class CheckInDAL : BaseDAL<CheckIn>
    {
        //implementar metodos de busca

        public QueryResponse<List<CheckIn>> GetByActiveState()
        {
            DbCommand command = DbFactory.GetCurrentCommand();
            command.CommandText = $"{_select} WHERE ACTIVE = @ACTIVE";
            command.Parameters.AddWithValue("@ACTIVE", true);

            return new DbExecuter().GetAllData<CheckIn>(command);
        }
    }
}
