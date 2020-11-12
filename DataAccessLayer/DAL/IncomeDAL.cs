using Common;
using DataAccessLayer.Infrastructure;
using Entities;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

                        //ver como atualizar o preço!

                        command.Parameters.Clear();
                        command.CommandText = @"INSERT INTO INCOMEITEMS (INCOMEID,PRODUCTID,QUANTITY,UNITYPRICE,PROFIT) VALUES (@INCOMEID,@PRODUCTID,@QUANTITY,@UNITYPRICE,@PROFIT); UPDATE PRODUCTS SET PRICE = @UNITYPRICE, STOCK += @QUANTITY WHERE ID = @PRODUCTID";
                        command.Parameters.AddWithValue("@INCOMEID", incomeItem.IncomeID);
                        command.Parameters.AddWithValue("@PRODUCTID", incomItemEntry.ProductID);
                        command.Parameters.AddWithValue("@QUANTITY", incomItemEntry.Quantity);
                        command.Parameters.AddWithValue("@UNITYPRICE", incomItemEntry.UnityPrice);
                        command.Parameters.AddWithValue("@PROFIT", incomItemEntry.Profit);

                        Response responseInsert = new DbExecuter().ExecuteQuery(command);
                        if (!responseInsert.Success)
                            return responseInsert;
                    }
                }
                scope.Complete();
                return Response.CreateSuccess("Operação efetuada com sucesso!");
            }
        }


        public Response Update(Income income)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                //atualizar descrição e nome produto reutilizando nosso metodo pronto
                Response resultUpdateIncome = base.Update(income);
                if (!resultUpdateIncome.Success)
                    return resultUpdateIncome;

                //Esse delete recebe o nome do campo e o ID para excluir. <IncomeItem> para que a retirar a table name
                //esse método não altera o valor do produto, rever!!!!
                Response resultDelete = DeleteWhereId<IncomeItem>("INCOMEID", income.ID);
                if (!resultDelete.Success)
                    return resultDelete;

                using (DbCommand command = DbFactory.GetCurrentCommand())
                {
                    foreach (IncomeItem incomItemEntry in income.IncomeItems)
                    {
                        IncomeItem incomeItem = new IncomeItem
                        {
                            IncomeID = income.ID,
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

        public Response UpdatePrice(Income income)
        {
            using (DbCommand command = DbFactory.GetCurrentCommand())
            {
                foreach (IncomeItem incomItemEntry in income.IncomeItems)
                {
                    command.Parameters.Clear();
                    command.CommandText = @"UPDATE PRODUCTS SET PRICE = @PRICE WHERE ID = @ID";
                    command.Parameters.AddWithValue("@ID", incomItemEntry.ProductID);
                    command.Parameters.AddWithValue("@PRICE", incomItemEntry.UnityPrice);
                    Response responseInsert = new DbExecuter().ExecuteQuery(command);
                    if (!responseInsert.Success)
                        return responseInsert;
                }
                return Response.CreateSuccess("Operação efetuada com sucesso!");
            }
        }


        public Response Delete(Income income)
        {
            Response resultDeleteIncomeItems = DeleteWhereId<IncomeItem>("INCOMEID", income.ID);
            if (!resultDeleteIncomeItems.Success)
                return resultDeleteIncomeItems;

            Response resultDeleteIncome = base.Delete(income);
            if (!resultDeleteIncome.Success)
                return resultDeleteIncome;

            return Response.CreateSuccess("Operação efetuada com sucesso!");
        }


        public QueryResponse<List<IncomeItem>> GetByIncomeId(int id)
        {
            DbCommand command = DbFactory.GetCurrentCommand();
            command.CommandText = "SELECT * FROM INCOMEITEMS WHERE INCOMEID = @INCOMEID";
            command.Parameters.AddWithValue("@INCOMEID", id);
            return new DbExecuter().GetAllData<IncomeItem>(command);
        }



    }
}
