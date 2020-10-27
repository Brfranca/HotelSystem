using Common;
using DataAccessLayer.Infrastructure;
using Entities;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DAL
{
    public class SupplierDAL : BaseDAL<Supplier>, IEntityCRUD<Supplier>
    {
        public QueryResponse<Supplier> GetByCnpj(Supplier supplier)
        {
            DbCommand command = DbFactory.GetCurrentCommand();
            command.CommandText = $"{_select} WHERE CNPJ = @CNPJ";
            command.Parameters.AddWithValue("@CNPJ", supplier.CNPJ);
            return new DbExecuter().GetSingleData<Supplier>(command);
        }

        public bool ExistCnpj(string cnpj, int id)
        {
            return Exist(cnpj, id, "CNPJ");
        }

        private bool Exist(string value, int id, string columnName)
        {
            DbCommand command = DbFactory.GetCurrentCommand();
            string and = "";
            if (id > 0)
            {
                command.Parameters.AddWithValue($"@ID", id);
                and = "AND ID <> @ID";
            }
            command.CommandText = $"{_select} WHERE {columnName} = @{columnName} {and}";
            command.Parameters.AddWithValue($"@{columnName}", value);
            return new DbExecuter().ExistData(command);
        }
        
    }
}
