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
    public class EmployeeDAL : BaseDAL<Employee>, IEntityCRUD<Employee>
    {
        public QueryResponse<Employee> GetByCpf(string cpf)
        {
            /*
            DbFactory.GetCurrentCommand tem como retorno: GetInstance()._provider.CreateCommand()
            _provider = DbProviderFactories.GetFactory(_providerName);
            _providerName = ConfigurationManager.ConnectionStrings[currentConnection].ProviderName;
            ProviderName: string dentro do App.config que está dentro do PresentationLayer 
            podendo ser "SqlServerConnection", "OracleServerCOnnection"... dependendo de qual banco de dados 
            está sendo utilizado
            */

            DbCommand command = DbFactory.GetCurrentCommand();
            command.CommandText = $"{_select} WHERE CPF = @CPF";
            command.Parameters.AddWithValue("@CPF", cpf);
            return new DbExecuter().GetSingleData<Employee>(command);
        }

        public QueryResponse<Employee> GetByRg(string rg)
        {
            DbCommand command = DbFactory.GetCurrentCommand();
            command.CommandText = $"{_select} WHERE RG = @RG";
            command.Parameters.AddWithValue("@RG", rg);
            return new DbExecuter().GetSingleData<Employee>(command);
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
    }
}
