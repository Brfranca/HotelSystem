using Common;
using DataAccessLayer.Infrastructure;
using Entities.Entities;
using Entities.Enums;
using System.Data.Common;
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
                    command.CommandText = @"UPDATE CHECKINS SET ACTIVE = @ACTIVE WHERE ID = @CHECKINID; UPDATE ROOMS SET ROOMSTATUS = @ROOMSTATUS WHERE ID = @ROOMID";
                    command.Parameters.AddWithValue("@CHECKINID", checkOut.CheckInID);
                    command.Parameters.AddWithValue("@ACTIVE", false);
                    command.Parameters.AddWithValue("@ROOMID", checkIn.RoomID);
                    command.Parameters.AddWithValue("@ROOMSTATUS", RoomStatus.Disponível);

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
