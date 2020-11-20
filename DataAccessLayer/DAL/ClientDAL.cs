using BusinessLogicalLayer.Extentions;
using Common;
using DataAccessLayer.DAL;
using DataAccessLayer.Infrastructure;
using Entities;
using System.Data.Common;

namespace DataAccessLayer
{
    public class ClientDAL : BaseDAL<Client>, IEntityCRUD<Client>
    {
        //Método que recupera dados de um dado cliente de acordo com o CPF
        public QueryResponse<Client> GetByCpf(string cpf)
        {
            cpf = cpf.RemoveMaskCPF();
            DbCommand command = DbFactory.GetCurrentCommand();
            command.CommandText = $"{_select} WHERE CPF = @CPF";
            command.Parameters.AddWithValue("@CPF", cpf);
            return new DbExecuter().GetSingleData<Client>(command);
        }
        //Método que recupera dados de um dado cliente de acordo com o RG
        public QueryResponse<Client> GetByRg(string rg)
        {
            DbCommand command = DbFactory.GetCurrentCommand();
            command.CommandText = $"{_select} WHERE RG = @RG";
            command.Parameters.AddWithValue("@RG", rg);
            return new DbExecuter().GetSingleData<Client>(command);
        }

        //Verifica se o CPF já foi cadastrado no banco de dados
        public bool ExistCpf(string cpf, int id)
        {
            return Exist(cpf, id, "CPF");
        }

        //Verifica se o RG já foi cadastrado no banco de dados
        public bool ExistRg(string rg, int id)
        {
            return Exist(rg, id, "RG");
        }

        //Verifica se o email já foi cadastrado no banco de dados
        public bool ExistEmail(string email, int id)
        {
            return Exist(email, id, "EMAIL");
        }
    }
}
