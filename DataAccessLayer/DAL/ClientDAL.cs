using Common;
using DataAccessLayer.Infrastructure;
using Entities;
using System.Collections.Generic;
using System.Data.Common;

namespace DataAccessLayer
{
    public class ClientDAL : IEntityCRUD<Client>
    {
        private const string _select = "SELECT * FROM CLIENTS";

        public Response Insert(Client client)
        {
            DbCommand command = SqlGenerator<Client>.BuildInsertCommand(client);
            return new DbExecuter().Execute(command);
        }

        public Response Update(Client client)
        {
            DbCommand command = SqlGenerator<Client>.BuildUpdateCommand(client);
            return new DbExecuter().Execute(command);
        }

        public Response Delete(Client client)
        {
            DbCommand command = SqlGenerator<Client>.BuildDeleteCommand(client);
            return new DbExecuter().Execute(command);
        }

        public QueryResponse<List<Client>> GetAll()
        {
            DbCommand command = DbFactory.GetCurrentCommand();
            command.CommandText = _select;
            return new DbExecuter().GetAllData<Client>(command);
        }

        public QueryResponse<Client> GetById(int id)
        {
            DbCommand command = DbFactory.GetCurrentCommand();
            command.CommandText = $"{_select} WHERE ID = @ID";
            command.Parameters.AddWithValue("@ID", id);
            return new DbExecuter().GetSingleData<Client>(command);
        }

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
