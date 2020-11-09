using Common;
using DataAccessLayer.Infrastructure;
using Entities;
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
    public class IncomeDAL : BaseDAL<Income>, IEntityCRUD<Income>
    {
        public Response Insert(Income income)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                Response resultInsertIncome = base.InsertScalar(income);
                if (!resultInsertIncome.Success)
                    return resultInsertIncome;

                using (DbCommand command = DbFactory.GetCurrentCommand())
                {
                    foreach (IncomeItem incomItemEntry in income.IncomeItems)
                    {
                        IncomeItem incomeItem = new IncomeItem
                        {
                            IncomeID = resultInsertIncome.Id,
                        };
                        command.Parameters.Clear();
                        command.CommandText = @"INSERT INTO INCOMEITEMS (INCOMEID,PRODUCTID,QUANTITY,UNITYPRICE) VALUES (@INCOMEID,@PRODUCTID,@QUANTITY,@UNITYPRICE); UPDATE PRODUCTS SET STOCK += @QUANTITY WHERE ID = @PRODUCTID";
                        command.Parameters.AddWithValue("@INCOMEID", incomeItem.IncomeID);
                        command.Parameters.AddWithValue("@PRODUCTID", incomItemEntry.ProductID);
                        command.Parameters.AddWithValue("@QUANTITY", incomItemEntry.Quantity);
                        command.Parameters.AddWithValue("@UNITYPRICE", incomItemEntry.UnityPrice);
                        Response responseInsert = new DbExecuter().ExecuteQuery(command);
                        if (!responseInsert.Success)
                            return responseInsert;
                    }
                }
                scope.Complete();
                return Response.CreateSuccess("Operação efetuada com sucesso!");
            }
        }
    }
}
