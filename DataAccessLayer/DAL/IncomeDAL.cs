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
                        command.CommandText = "INSERT INTO INCOMEITEMS (INCOMEID, PRODUCTID,QUANTITY,UNITYPRICE) VALUES (@INCOMEID,@PRODUCTID,@QUANTITY,@UNITYPRICE)";
                        command.Parameters.AddWithValue("@INCOMEID", income.ID);
                        command.Parameters.AddWithValue("@PRODUCTID", incomeItem.ProductID);
                        command.Parameters.AddWithValue("@QUANTITY", incomeItem.Quantity);
                        command.Parameters.AddWithValue("@UNITYPRICE", incomeItem.UnityPrice);
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
