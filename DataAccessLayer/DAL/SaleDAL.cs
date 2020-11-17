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
    public class SaleDAL : BaseDAL<Sale>, IEntityCRUD<Sale>
    {
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
                        SaleItem saleItem = new SaleItem
                        {
                            SaleId = resultInsert.Id
                        };

                        cmd.CommandText = @"INSERT INTO SALEITEMS (SALEID,PRODUCTID,QUANTITY,UNITYPRICE) VALUES (@SALEID,@PRODUCTID,@QUANTITY,@UNITYPRICE) WHERE SALEID = @SALEID; UPDATE PRODUCTS SET STOCK -= @QUANTITY WHERE ID = @PRODUCTID";
                        cmd.Parameters.AddWithValue("@SALEID", item.SaleId);
                        cmd.Parameters.AddWithValue("@PRODUCTID", item.ProductId);
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
    }
}