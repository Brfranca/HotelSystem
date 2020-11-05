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


        //Método novo, nao sei se funciona. Ass: kj
        public QueryResponse<List<Supplier_Product>> GetAssociativeTable(int id)
        {
            DbCommand command = DbFactory.GetCurrentCommand();
            command.CommandText = "SELECT * FROM SUPPLIERS_PRODUCTS WHERE PRODUCTID = @PRODUCTID";
            command.Parameters.AddWithValue("@PRODUCTID", id);
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
