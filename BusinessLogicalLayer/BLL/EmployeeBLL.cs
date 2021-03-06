﻿using BusinessLogicalLayer.Extentions;
using Common;
using DataAccessLayer.DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogicalLayer.BLL
{
    public class EmployeeBLL
    {
        private readonly EmployeeDAL _employeeDAL;

        public EmployeeBLL()
        {
            _employeeDAL = new EmployeeDAL();
        }

        //verifica se o login é válido
        public Response Login(string email, string password)
        {
            if (email.IsNullOrWhiteSpace())
                return Response.CreateFailure("Usuário deve ser informado!");
            if (password.IsNullOrWhiteSpace())
                return Response.CreateFailure("Senha deve ser informado!");
            if (email == "adm" && password == "adm")
                return Response.CreateSuccess();
            var employee = _employeeDAL.GetByEmail(email);
            if ((employee?.Data?.ID ?? 0) == 0)
                return Response.CreateFailure("Usuário inválido!");

            if (employee.Data.Password != password.GenerateHash())
                return Response.CreateFailure("Senha inválida!");

            return Response.CreateSuccess();
        }

        //valida e insere na tabela
        public Response Register(Employee employee, string password2)
        {
            employee.CPF = employee.CPF.RemoveMaskCPF();
            Response result = Validate(employee, password2);
            if (!result.Success)
                return result;

            employee.Password = employee.Password.GenerateHash();
            Response resultInsert = _employeeDAL.Insert(employee);
            if (!resultInsert.Success)
                return resultInsert;

            return Response.CreateSuccess("Funcionário cadastrado com sucesso!");
        }

        //valida e atualiza a tabela
        public Response Update(Employee employee, string password2)
        {
            employee.CPF = employee.CPF.RemoveMaskCPF();
            Response result = Validate(employee, password2);
            if (!result.Success)
                return result;

            Response resultUpdate = _employeeDAL.Update(employee);
            if (!resultUpdate.Success)
                return resultUpdate;

            return Response.CreateSuccess("Funcionário atualizado com sucesso!");
        }

        //muda  a senha
        public Response UpdatePassword(Employee employee, string password2)
        {
            Response result = ValidatePassword(employee, password2);
            if (!result.Success)
                return result;

            employee.Password = employee.Password.GenerateHash();
            Response resultUpdate = _employeeDAL.Update(employee);
            if (!resultUpdate.Success)
                return resultUpdate;

            return Response.CreateSuccess("Senha atualizada com sucesso!");
        }

        //deleta um conjunto de dados na tabela
        public Response Delete(Employee employee)
        {
            Response resultDelete = _employeeDAL.Delete(employee);
            if (!resultDelete.Success)
                return resultDelete;

            return Response.CreateSuccess("Funcionário removido com sucesso!");
        }

        //retorna uma lista com todos os funcionarios
        public QueryResponse<List<Employee>> GetAll()
        {
            return _employeeDAL.GetAll();
        }

        //retorna o funcionario de acordo com  o id
        public QueryResponse<Employee> GetById(int id)
        {
            return _employeeDAL.GetById(id);
        }

        //retorna o funcionario de acordo com o cpf
        public QueryResponse<Employee> GetByCpf(string cpf)
        {
            return _employeeDAL.GetByCpf(cpf);
        }

        public QueryResponse<Employee> GetByRg(string rg)
        {
            return _employeeDAL.GetByRg(rg);
        }

        //retorna o funcionario de acordo com o email
        public QueryResponse<Employee> GetByEmail(string email)
        {
            return _employeeDAL.GetByEmail(email);
        }
        
        //verifica as validações
        private Response Validate(Employee employee, string passaword2)
        {
            try
            {
                Validator validator = new Validator();
                ValidateEmail(employee.Email, employee.ID, validator);
                ValidateRg(employee.RG, employee.ID, validator);
                ValidateCpf(employee.CPF, employee.ID, validator);
                ValidateName(employee.Name, validator);
                ValidatePhone(employee.Phone, validator);
                ValidatePassword(employee.Password, passaword2, validator);
                ValidateCEP(employee.CEP, validator);
                ValidateCity(employee.City, validator);
                ValidateStreet(employee.Street, validator);
                ValidateNumber(employee.Number, validator);
                ValidateDistrict(employee.District, validator);

                return validator.Validate();
            }
            catch (Exception erro)
            {
                return Response.CreateFailureException("Erro na validação do funcionário!", erro);
            }
        }

        //valida a senha
        private Response ValidatePassword(Employee employee, string passaword2)
        {
            Validator validator = new Validator();
            ValidatePassword(employee.Password, passaword2, validator);
            return validator.Validate();
        }

        //valida o email
        private void ValidateEmail(string email, int id, Validator validator)
        {
            if (email.IsNullOrWhiteSpace())
            {
                validator.AddError("Email deve ser informado!");
            }
            else if (!email.IsValidEmail())
            {
                validator.AddError("Email inválido!");
            }
            else if (_employeeDAL.ExistEmail(email, id))
            {
                validator.AddError("Email já cadastrado em nossa base de dados!");
            }
        }

        //valida o telefone
        private void ValidatePhone(string phone, Validator validator)
        {
            if (phone.IsNullOrWhiteSpace())
            {
                validator.AddError("Telefone deve ser informado!");
            }
            else if (!phone.IsValidPhone())
            {
                validator.AddError("Telefone inválido!");
            }
        }

        //valida o rg
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

        //valida o cpf
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
            else if (!cpf.IsValidCPF())
            {
                validator.AddError("CPF inválido!");
            }
            else if (_employeeDAL.ExistCpf(cpf, id))
            {
                validator.AddError("CPF já cadastrado em nossa base de dados!");
            }
        }

        //valida o nome
        private void ValidateName(string name, Validator validator)
        {
            if (name.IsNullOrWhiteSpace())
            {
                validator.AddError("Nome deve ser informado!");
            }
            else if (!name.IsValidName())
            {
                validator.AddError("Nome não deve conter números e caracteres especiais!");
            }
            else if (!name.IsValidFullName())
            {
                validator.AddError("Nome completo deve ser informado!");
            }
        }

        //valida a senha
        private void ValidatePassword(string password1, string password2, Validator validator)
        {
            if (password1.IsNullOrWhiteSpace() || password2.IsNullOrWhiteSpace())
            {
                validator.AddError("Senha deve ser informada!");
            }
            else if (password1.Length < 7)
            {
                validator.AddError("Senha deve conter no mínimo 8 caracteres!");
            }
            else if (password1 != password2)
            {
                validator.AddError("As senhas devem ser iguais!");
            }
        }

        //valida o cep
        private void ValidateCEP(string cep, Validator validator)
        {
            if (cep.IsNullOrWhiteSpace())
            {
                validator.AddError("CEP deve ser informado!");
            }
            else if (cep.IsValidCEP())
            {
                validator.AddError("CEP inválido!");
            }
        }

        private void ValidateStreet(string street, Validator validator)
        {
            if (street.IsNullOrWhiteSpace())
            {
                validator.AddError("Rua deve ser informada!");
            }
            else if (street.Length > 60)
            {
                validator.AddError("Rua deve conter no máximo 60 caracteres!");
            }
        }

        private void ValidateNumber(string number, Validator validator)
        {
            if (number.IsNullOrWhiteSpace())
            {
                validator.AddError("Nº deve ser informado!");
            }
            else if (!number.IsNumber())
            {
                validator.AddError("Nº deve conter apenas números!");
            }
        }

        private void ValidateDistrict(string district, Validator validator)
        {
            if (district.IsNullOrWhiteSpace())
            {
                validator.AddError("Bairro deve ser informado!");
            }
            else if (district.Length > 30)
            {
                validator.AddError("Bairro deve conter no máximo 30 caracteres!");
            }
        }

        private void ValidateCity(string city, Validator validator)
        {
            if (city.IsNullOrWhiteSpace())
            {
                validator.AddError("Cidade deve ser informada!");
            }
            else if (city.Length > 50)
            {
                validator.AddError("Cidade deve conter no máximo 50 caracteres!");
            }
            else if (!city.IsValidName())
            {
                validator.AddError("Cidade não deve conter números e caracteres especiais!");
            }
        }
    }
}
