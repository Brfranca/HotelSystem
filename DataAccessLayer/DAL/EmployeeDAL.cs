using BusinessLogicalLayer.Extentions;
using Common;
using DataAccessLayer.Infrastructure;
using Entities;
using System.Data.Common;

namespace DataAccessLayer.DAL
{
    public class EmployeeDAL : BaseDAL<Employee>, IEntityCRUD<Employee>
    {
        public QueryResponse<Employee> GetByCpf(string cpf)
        {
            cpf = cpf.RemoveMaskCPF();
            DbCommand command = DbFactory.GetCurrentCommand();
            command.CommandText = $"{_select} WHERE CPF = @CPF";
            command.Parameters.AddWithValue("@CPF", cpf);
            return new DbExecuter().GetSingleData<Employee>(command);
        }

        public QueryResponse<Employee> GetByEmail(string email)
        {
            DbCommand command = DbFactory.GetCurrentCommand();
            command.CommandText = $"{_select} WHERE EMAIL = @EMAIL";
            command.Parameters.AddWithValue("@EMAIL", email);
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
