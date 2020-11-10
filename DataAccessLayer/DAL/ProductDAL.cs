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
                return Response.CreateSuccess("Operação efetuada com sucesso!");
            }
        }

        public Response Update(Product product)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                //atualizar descrição e nome produto reutilizando nosso metodo pronto
                Response resultUpdateProduct = base.Update(product);
                if (!resultUpdateProduct.Success)
                    return resultUpdateProduct;

                //Esse delete recebe o nome do campo e o ID para excluir. <Supplier_Product> para que a retirar a table name
                Response resultDelete = DeleteWhereId<Supplier_Product>("PRODUCTID", product.ID);
                if (!resultDelete.Success)
                    return resultDelete;

                Response resultInsertSupplier = InsertSupplierOfProduct(product.ID, product.SuppliersID);
                if (!resultInsertSupplier.Success)
                    return resultInsertSupplier;

                scope.Complete();
                return Response.CreateSuccess("Operação efetuada com sucesso!");
            }
        }

        public Response Delete(Product product)
        {
            Response resultDeleteSupplier = DeleteWhereId<Supplier_Product>("PRODUCTID", product.ID);
            if (!resultDeleteSupplier.Success)
                return resultDeleteSupplier;

            Response resultDeleteProduct = base.Delete(product);
            if (!resultDeleteProduct.Success)
                return resultDeleteProduct;

            return Response.CreateSuccess("Operação efetuada com sucesso!");
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

        public Response InsertSupplierOfProduct(int productID, List<int> suppliersID)
        {
            foreach (var id in suppliersID)
            {
                Supplier_Product suppliers_products = new Supplier_Product
                {
                    ProductID = productID,
                    SupplierID = id
                };
                Response resultInsertNs = base.Insert(suppliers_products);
                if (!resultInsertNs.Success)
                    return resultInsertNs;
            }
            return Response.CreateSuccess();
        }

        public Response DeleteWhereId<T>(string field, int id)
        {
            DbCommand command = SqlGenerator<T>.BuildDeleteWhereIdCommand(field, id);
            return new DbExecuter().ExecuteQuery(command);
        }
    }
}
