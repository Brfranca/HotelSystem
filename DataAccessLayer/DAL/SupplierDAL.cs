using BusinessLogicalLayer.Extentions;
using Common;
using DataAccessLayer.Infrastructure;
using Entities;
using System.Data.Common;

namespace DataAccessLayer.DAL
{
    public class SupplierDAL : BaseDAL<Supplier>, IEntityCRUD<Supplier>
    {
        //retorna um fornecedor de acordo com o cnpj
        public QueryResponse<Supplier> GetByCnpj(string cnpj)
        {
            cnpj = cnpj.RemoveMaskCNPJ();
            DbCommand command = DbFactory.GetCurrentCommand();
            command.CommandText = $"{_select} WHERE CNPJ = @CNPJ";
            command.Parameters.AddWithValue("@CNPJ", cnpj);
            return new DbExecuter().GetSingleData<Supplier>(command);
        }

        //retorna um fornecedor de acordo com a razão social
        public QueryResponse<Supplier> GetByCompanyName(string companyName)
        {
            DbCommand command = DbFactory.GetCurrentCommand();
            command.CommandText = $"{_select} WHERE COMPANYNAME = @COMPANYNAME";
            command.Parameters.AddWithValue("@COMPANYNAME", companyName);
            return new DbExecuter().GetSingleData<Supplier>(command);
        }

        //verifica se o cnpj já está no banco de dados
        public bool ExistCnpj(string cnpj, int id)
        {
            return Exist(cnpj, id, "CNPJ");
        }

        //verifica se o email já está no banco de dados
        public bool ExistEmail(string email, int id)
        {
            return Exist(email, id, "EMAIL");
        }
    }
}
