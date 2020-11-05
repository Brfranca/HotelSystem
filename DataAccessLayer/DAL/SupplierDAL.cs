using BusinessLogicalLayer.Extentions;
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
        public QueryResponse<Supplier> GetByCnpj(string cnpj)
        {
            cnpj = cnpj.RemoveMaskCNPJ();
            DbCommand command = DbFactory.GetCurrentCommand();
            command.CommandText = $"{_select} WHERE CNPJ = @CNPJ";
            command.Parameters.AddWithValue("@CNPJ", cnpj);
            return new DbExecuter().GetSingleData<Supplier>(command);
        }

        public QueryResponse<Supplier> GetByCompanyName(string companyName)
        {
            DbCommand command = DbFactory.GetCurrentCommand();
            command.CommandText = $"{_select} WHERE COMPANYNAME = @COMPANYNAME";
            command.Parameters.AddWithValue("@COMPANYNAME", companyName);
            return new DbExecuter().GetSingleData<Supplier>(command);
        }
        public bool ExistCnpj(string cnpj, int id)
        {
            return Exist(cnpj, id, "CNPJ");
        }

        public bool ExistEmail(string email, int id)
        {
            return Exist(email, id, "EMAIL");
        }
    }
}
