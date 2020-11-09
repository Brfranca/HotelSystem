using Common;
using DataAccessLayer.Infrastructure;
using Entities;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DataAccessLayer.DAL
{
    public class ProductDAL : BaseDAL<Product>, IEntityCRUD<Product>
    {
        public Response Insert(Product product)
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                Response resultInsertProduct = base.InsertScalar(product);
                if (!resultInsertProduct.Success)
                    return resultInsertProduct;

                foreach (var id in product.SuppliersID)
                {
                    Supplier_Product suppliers_products = new Supplier_Product
                    {
                        ProductID = resultInsertProduct.Id,
                        SupplierID = id
                    };
                    Response resultInsertNs = base.Insert(suppliers_products);
                    if (!resultInsertNs.Success)
                        return resultInsertNs;
                }
                transaction.Complete();
                return Response.CreateSuccess();
            }
        }

        public Response Update(Product product)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (DbCommand command = DbFactory.GetCurrentCommand())
                {
                    command.CommandText =
                    @"UPDATE PRODUCTS SET NAME = @NAME, DESCRIPTION = @DESCRIPTION WHERE ID = @ID; DELETE FROM SUPPLIERS_PRODUCTS WHERE PRODUCTID = @ID";
                    command.Parameters.AddWithValue("@NAME", product.Name);
                    command.Parameters.AddWithValue("@DESCRIPTION", product.Description);
                    command.Parameters.AddWithValue("@ID", product.ID);
                    Response response = new DbExecuter().ExecuteQuery(command);
                    if (!response.Success)
                        return response;
                    
                    foreach (int id in product.SuppliersID)
                    {
                        command.Parameters.Clear();
                        command.CommandText = @"INSERT INTO SUPPLIERS_PRODUCTS (SUPPLIERID,PRODUCTID) VALUES (@SUPPLIERID,@PRODUCTID)";
                        command.Parameters.AddWithValue("@PRODUCTID", product.ID);
                        command.Parameters.AddWithValue("@SUPPLIERID", id);
                        Response responseInsert = new DbExecuter().ExecuteQuery(command);
                        if (!responseInsert.Success)
                            return responseInsert;
                    }
                }
                scope.Complete();
                return Response.CreateSuccess("Operação efetuada com sucesso!");
            }
        }

        public Response Delete(Product product)
        {
            using (DbCommand command = DbFactory.GetCurrentCommand())
            {
                command.CommandText =
                @"DELETE FROM SUPPLIERS_PRODUCTS WHERE PRODUCTID = @ID; DELETE FROM PRODUCTS WHERE ID = @ID";
                command.Parameters.AddWithValue("@ID", product.ID);
                return new DbExecuter().ExecuteQuery(command);
                
            }
        }

        //Método novo, nao sei se funciona. Ass: kj
        public QueryResponse<List<Supplier_Product>> GetByProductId(int id)
        {
            DbCommand command = DbFactory.GetCurrentCommand();
            command.CommandText = "SELECT * FROM SUPPLIERS_PRODUCTS WHERE PRODUCTID = @PRODUCTID";
            command.Parameters.AddWithValue("@PRODUCTID", id);
            return new DbExecuter().GetAllData<Supplier_Product>(command);

        }

        public QueryResponse<List<Supplier_Product>> GetBySupplierId(int id)
        {
            DbCommand command = DbFactory.GetCurrentCommand();
            command.CommandText = "SELECT * FROM SUPPLIERS_PRODUCTS WHERE SUPPLIERID = @SUPPLIERID";
            command.Parameters.AddWithValue("@SUPPLIERID", id);
            return new DbExecuter().GetAllData<Supplier_Product>(command);

        }


        public bool ExistName(string name, int id)
        {
            return Exist(name, id, "NAME");
        }

        public bool ExistDescription(string description, int id)
        {
            return Exist(description, id, "DESCRIPTION");
        }
    }

}
