using Common;
using DataAccessLayer.Infrastructure;
using Entities.Entities;
using System.Collections.Generic;
using System.Data.Common;
using System.Transactions;

namespace DataAccessLayer.DAL
{
    public class SaleDAL : BaseDAL<Sale>, IEntityCRUD<Sale>
    {
        //Inserena tabela de sales e recupera o ID gerado e faze update no estoque de products
        public Response Insert(Sale sale)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                Response resultInsert = base.InsertScalar(sale);
                if (!resultInsert.Success)
                    return resultInsert;

                using (DbCommand cmd = DbFactory.GetCurrentCommand())
                {
                    foreach (var item in sale.SaleItems)
                    {
                        item.SaleID = resultInsert.GeneratedId;

                        cmd.Parameters.Clear();
                        cmd.CommandText = @"INSERT INTO SALEITEMS (SALEID,PRODUCTID,QUANTITY,UNITYPRICE) VALUES (@SALEID,@PRODUCTID,@QUANTITY,@UNITYPRICE); UPDATE PRODUCTS SET STOCK -= @QUANTITY WHERE ID = @PRODUCTID";
                        cmd.Parameters.AddWithValue("@SALEID", item.SaleID);
                        cmd.Parameters.AddWithValue("@PRODUCTID", item.ProductID);
                        cmd.Parameters.AddWithValue("@QUANTITY", item.Quantity);
                        cmd.Parameters.AddWithValue("@UNITYPRICE", item.UnityPrice);

                        Response responseInsertSale = new DbExecuter().ExecuteQuery(cmd);
                        if (!responseInsertSale.Success)
                            return responseInsertSale;
                    }
                }

                scope.Complete();
                return Response.CreateSuccess("Operação efetuada com sucesso");
            }
        }

        //retorna uma lista de vendas de acordo com o id do cliente
        public QueryResponse<List<Sale>> GetByClientId(int id)
        {
            DbCommand command = DbFactory.GetCurrentCommand();
            command.CommandText = @"SELECT * FROM SALES WHERE CLIENTID = @CLIENTID";
            command.Parameters.AddWithValue("@CLIENTID", id);
            return new DbExecuter().GetAllData<Sale>(command);
        }

        //retorna uma lista de itens da venda de acordo com o id da venda
        public QueryResponse<List<SaleItem>> GetBySaleId(int id)
        {
            DbCommand command = DbFactory.GetCurrentCommand();
            command.CommandText = @"SELECT * FROM SALEITEMS WHERE SALEID = @SALEID";
            command.Parameters.AddWithValue("@SALEID", id);
            return new DbExecuter().GetAllData<SaleItem>(command);
        }
    }
}