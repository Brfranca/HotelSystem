﻿using Common;
using DataAccessLayer.Infrastructure;
using Entities;
using Entities.Entities;
using System.Collections.Generic;
using System.Data.Common;
using System.Transactions;

namespace DataAccessLayer.DAL
{
    public class IncomeDAL : BaseDAL<Income>, IEntityCRUD<Income>
    {
        //Insere na tabela de incomes no banco de dados e atualiza o estoque de produtos
        public Response Insert(Income income)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                Response resultInsertIncome = base.InsertScalar(income);
                if (!resultInsertIncome.Success)
                    return resultInsertIncome;

                using (DbCommand command = DbFactory.GetCurrentCommand())
                {
                    foreach (IncomeItem incomeItem in income.IncomeItems)
                    {
                        incomeItem.IncomeID = resultInsertIncome.GeneratedId;
                        command.Parameters.Clear();
                        command.CommandText = @"INSERT INTO INCOMEITEMS (INCOMEID,PRODUCTID,QUANTITY,UNITYPRICE,PROFIT) VALUES (@INCOMEID,@PRODUCTID,@QUANTITY,@UNITYPRICE,@PROFIT); UPDATE PRODUCTS SET PRICE = @UNITYPRICE, STOCK += @QUANTITY WHERE ID = @PRODUCTID";
                        command.Parameters.AddWithValue("@INCOMEID", incomeItem.IncomeID);
                        command.Parameters.AddWithValue("@PRODUCTID", incomeItem.ProductID);
                        command.Parameters.AddWithValue("@QUANTITY", incomeItem.Quantity);
                        command.Parameters.AddWithValue("@UNITYPRICE", incomeItem.UnityPrice);
                        command.Parameters.AddWithValue("@PROFIT", incomeItem.Profit);

                        Response responseInsert = new DbExecuter().ExecuteQuery(command);
                        if (!responseInsert.Success)
                            return responseInsert;
                    }
                }
                scope.Complete();
                return Response.CreateSuccess("Operação efetuada com sucesso!");
            }
        }

        //atualiza 
        public Response Update(Income income)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                Response resultUpdateIncome = base.Update(income);
                if (!resultUpdateIncome.Success)
                    return resultUpdateIncome;

                Response resultDelete = DeleteWhereId<IncomeItem>("INCOMEID", income.ID);
                if (!resultDelete.Success)
                    return resultDelete;

                using (DbCommand command = DbFactory.GetCurrentCommand())
                {
                    foreach (IncomeItem incomeItemEntry in income.IncomeItems)
                    {
                        incomeItemEntry.IncomeID = income.ID;
                        command.Parameters.Clear();
                        command.CommandText = @"INSERT INTO INCOMEITEMS (INCOMEID,PRODUCTID,QUANTITY,UNITYPRICE) VALUES (@INCOMEID,@PRODUCTID,@QUANTITY,@UNITYPRICE); UPDATE PRODUCTS SET STOCK += @QUANTITY WHERE ID = @PRODUCTID";
                        command.Parameters.AddWithValue("@INCOMEID", incomeItemEntry.IncomeID);
                        command.Parameters.AddWithValue("@PRODUCTID", incomeItemEntry.ProductID);
                        command.Parameters.AddWithValue("@QUANTITY", incomeItemEntry.Quantity);
                        command.Parameters.AddWithValue("@UNITYPRICE", incomeItemEntry.UnityPrice);
                        Response responseInsert = new DbExecuter().ExecuteQuery(command);
                        if (!responseInsert.Success)
                            return responseInsert;
                    }
                }

                scope.Complete();
                return Response.CreateSuccess("Operação efetuada com sucesso!");
            }
        }

        //Autalia o preço dos produtos de acordo com a entrada 
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

        //Retorna uma lista de incomeitems de acordo com o id do income

        public QueryResponse<List<IncomeItem>> GetByIncomeId(int id)
        {
            DbCommand command = DbFactory.GetCurrentCommand();
            command.CommandText = "SELECT * FROM INCOMEITEMS WHERE INCOMEID = @INCOMEID";
            command.Parameters.AddWithValue("@INCOMEID", id);
            return new DbExecuter().GetAllData<IncomeItem>(command);
        }
    }
}
