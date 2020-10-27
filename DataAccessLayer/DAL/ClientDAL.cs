using Common;
using DataAccessLayer.DAL;
using DataAccessLayer.Infrastructure;
using Entities;
using System.Data.Common;

namespace DataAccessLayer
{
    public class ClientDAL : BaseDAL<Client>, IEntityCRUD<Client>
    {
        public QueryResponse<Client> GetByCpf(string cpf)
        {
            DbCommand command = DbFactory.GetCurrentCommand();
            command.CommandText = $"{_select} WHERE CPF = @CPF";
            command.Parameters.AddWithValue("@CPF", cpf);
            return new DbExecuter().GetSingleData<Client>(command);
        }

        public QueryResponse<Client> GetByRg(string rg)
        {
            DbCommand command = DbFactory.GetCurrentCommand();
            command.CommandText = $"{_select} WHERE RG = @RG";
            command.Parameters.AddWithValue("@RG", rg);
            return new DbExecuter().GetSingleData<Client>(command);
        }

        public bool ExistCpf(string cpf, int id)
        {
            return Exist(cpf, id, "CPF");
        }

        public bool ExistRg(string rg, int id)
        {
            return Exist(rg, id, "RG");
        }

        public bool ExistEmail(string email, int id)
        {
            return Exist(email, id, "EMAIL");
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
