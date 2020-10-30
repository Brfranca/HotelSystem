using BusinessLogicalLayer.Extentions;
using Common;
using DataAccessLayer.DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.BLL
{
    public class EmployeeBLL
    {
        private readonly EmployeeDAL _employeeDAL;

        public EmployeeBLL()
        {
            _employeeDAL = new EmployeeDAL();
        }

        public Response Register(Employee employee)
        {
            Response result = Validate(employee);
            if (!result.Success)
                return result;


            Response resultInsert = _employeeDAL.Insert(employee);
            if (!resultInsert.Success)
                return resultInsert;

            //_employee.Insert(employee) vem do BaseDAL 

            return Response.CreateSuccess("Funcionário cadastrado com sucesso!");
        }

        public Response Update(Employee employee)
        {
            Response result = Validate(employee);
            if (!result.Success)
                return result;

            Response resultUpdate = _employeeDAL.Update(employee);
            if (!resultUpdate.Success)
                return resultUpdate;

            return Response.CreateSuccess("Funcionário atualizado com sucesso!");
        }


        public Response Delete(Employee employee)
        {
            Response resultDelete = _employeeDAL.Delete(employee);
            if (!resultDelete.Success)
                return resultDelete;

            return Response.CreateSuccess("Funcionário removido com sucesso!");
        }

        public QueryResponse<List<Employee>> GetAll()
        {
            return _employeeDAL.GetAll();
        }

        public QueryResponse<Employee> GetById(int id)
        {
            return _employeeDAL.GetById(id);
        }

        public QueryResponse<Employee> GetByCpf(string cpf)
        {
            return _employeeDAL.GetByCpf(cpf);
        }

        public QueryResponse<Employee> GetByRg(string rg)
        {
            return _employeeDAL.GetByRg(rg);
        }

        private Response Validate(Employee employee)
        {
            try
            {
                Validator validator = new Validator();
                ValidateEmail(employee.Email, employee.ID, validator);
                ValidateRg(employee.RG, employee.ID, validator);
                ValidateCpf(employee.CPF, employee.ID, validator);
                ValidateName(employee.Name, validator);
                ValidatePhone(employee.Phone, validator);

                return validator.Validate();

                /*
                O validator.Validate() verifica se o comprimento da StringBuilder _errors é igual a zero, 
                caso seja vai retornar Response.CreateSuccess();
                Caso nao seja retornará Response.CreateFailure(_errors.ToString());
                */

                //Por que usar o id nos métodos ValidateEmail, ValidateRg e ValidateCpf?????

            }
            catch (Exception erro)
            {
                return Response.CreateFailureException("Erro na validação do cliente!", erro);
            }
        }


        private void ValidateEmail(string email, int id, Validator validator)
        {
            if (email.IsNullOrWhiteSpace())
            {
                validator.AddError("Email deve ser informado!");
            }
            else if (email.IsValidEmail())
            {
                validator.AddError("Email inválido!");
            }
            else if (_employeeDAL.ExistEmail(email, id))
            {
                validator.AddError("Email já cadastrado em nossa base de dados!");
            }
        }

        private static void ValidatePhone(string phone, Validator validator)
        {
            if (phone.IsNullOrWhiteSpace())
            {
                validator.AddError("Telefone deve ser informado!");
            }
            else if (phone.IsValidPhone())
            {
                validator.AddError("Telefone inválido!");
            }
            
        }

        private void ValidateRg(string rg, int id, Validator validator)
        {
            if (rg.IsNullOrWhiteSpace())
            {
                validator.AddError("RG deve ser informado!");
            }
            else if (rg.Length < 4)
            {
                validator.AddError("RG inválido!");
            }
            else if (rg.Any(char.IsLetter))
            {
                validator.AddError("RG deve conter apenas números!");
            }
            else if (_employeeDAL.ExistRg(rg, id))
            {
                validator.AddError("RG já cadastrado em nossa base de dados!");
            }
        }

        private void ValidateCpf(string cpf, int id, Validator validator)
        {
            if (cpf.IsNullOrWhiteSpace())
            {
                validator.AddError("CPF deve ser informado!");
            }
            else if (cpf.Length < 11)
            {
                validator.AddError("CPF deve conter 11 caracteres!");
            }
            else if (cpf.IsValidCPF())
            {
                validator.AddError("CPF inválido!");
            }
            else if (_employeeDAL.ExistCpf(cpf, id))
            {
                validator.AddError("CPF já cadastrado em nossa base de dados!");
            }
        }

        private static void ValidateName(string name, Validator validator)
        {
            if (name.IsNullOrWhiteSpace())
            {
                validator.AddError("Nome deve ser informado!");
            }
            else if (name.IsValidName())
            {
                validator.AddError("Nome completo deve ser informado!");
            }
        }
    }
}
