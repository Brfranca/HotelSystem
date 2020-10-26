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
