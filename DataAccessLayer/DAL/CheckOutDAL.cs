using Common;
using DataAccessLayer.Infrastructure;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DataAccessLayer.DAL
{
    public class CheckOutDAL : BaseDAL<CheckOut>, IEntityCRUD<CheckOut>
    {
        public Response Insert(CheckOut checkOut)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                Response resultInsertIncome = base.Insert(checkOut);
                if (!resultInsertIncome.Success)
                    return resultInsertIncome;
                using (DbCommand command = DbFactory.GetCurrentCommand())
                {
                    CheckIn checkIn = new CheckIn()
                    {
                        ID = checkOut.CheckInID
                    };
                    command.Parameters.Clear();
                    command.CommandText = @"UPDATE CHECKINS SET ACTIVE = @ACTIVE WHERE ID = @CHECKINID";
                    command.Parameters.AddWithValue("@CHECKINID", checkOut.CheckInID);
                    command.Parameters.AddWithValue("@ACTIVE", false);

                    Response responseInsert = new DbExecuter().ExecuteQuery(command);
                    if (!responseInsert.Success)
                        return responseInsert;
                }
                scope.Complete();
                return Response.CreateSuccess("Operação efetuada com sucesso!");
            }
        }
    }
}
