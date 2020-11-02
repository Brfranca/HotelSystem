using BusinessLogicalLayer.Extentions;
using Common;
using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogicalLayer
{
    public class ClientBLL
    {
        private readonly ClientDAL _clienteDALL;
        public ClientBLL()
        {
            _clienteDALL = new ClientDAL();
        }

        public Response Register(Client client)
        {
            client.CPF = client.CPF.RemoveMaskCPF();
            Response result = Validate(client);
            if (!result.Success)
                return result;

            client.CPF = client.CPF.RemoveMaskCPF();
            Response resultInsert = _clienteDALL.Insert(client);
            if (!resultInsert.Success)
                return resultInsert;

            return Response.CreateSuccess("Cliente cadastrado com sucesso!");
        }

        public Response Update(Client client)
        {
            client.CPF = client.CPF.RemoveMaskCPF();
            Response result = Validate(client);
            if (!result.Success)
                return result;

            Response resultInsert = _clienteDALL.Update(client);
            if (!resultInsert.Success)
                return resultInsert;

            return Response.CreateSuccess("Cliente atualizado com sucesso!");
        }

        public Response Delete(Client client)
        {

            Response resultDelete = _clienteDALL.Delete(client);
            if (!resultDelete.Success)
                return resultDelete;

            return Response.CreateSuccess("Cliente removido com sucesso!");
        }

        public QueryResponse<List<Client>> GetAll()
        {
            return _clienteDALL.GetAll();
        }

        public QueryResponse<Client> GetByCpf(string cpf)
        {
            return _clienteDALL.GetByCpf(cpf);
        }

        public QueryResponse<Client> GetById(int id)
        {
            return _clienteDALL.GetById(id);
        }

        public QueryResponse<Client> GetByRg(string rg)
        {
            return _clienteDALL.GetByRg(rg);
        }

        public Response Validate(Client client)
        {
            try
            {
                Validator validator = new Validator();

                ValidateName(client.Name, validator);
                ValidateCpf(client.CPF, client.ID, validator);
                ValidateRg(client.RG, client.ID, validator);
                ValidatePhone(client.Phone1, client.Phone2, validator);
                ValidateEmail(client.Email, client.ID, validator);

                return validator.Validate();
            }
            catch (Exception erro)
            {
                return Response.CreateFailureException("Erro na validação do cliente, contate o administrador.", erro);
            }
        }

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
            else if (_clienteDALL.ExistEmail(email, id))
            {
                validator.AddError("Email já cadastrado em nossa base de dados!");
            }
        }

        private void ValidatePhone(string phone1, string phone2, Validator validator)
        {
            if (phone1.IsNullOrWhiteSpace())
            {
                validator.AddError("Telefone 1 deve ser informado!");
            }
            else if (!phone1.IsValidPhone())
            {
                validator.AddError("Telefone 1 inválido!");
            }
            if (phone2.HasValue())
            {
                //Caso tenha valor ver se é valido
                if (!phone2.IsValidPhone())
                {
                    validator.AddError("Telefone 2 inválido!");
                }
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
            else if (_clienteDALL.ExistRg(rg, id))
            {
                validator.AddError("RG já cadastrados em nossa base de dados!");
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
            else if (!cpf.IsValidCPF())
            {
                validator.AddError("CPF inválido!");
            }
            else if (_clienteDALL.ExistCpf(cpf, id))
            {
                validator.AddError("CPF já cadastrado em nossa base de dados!");
            }
        }

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
    }
}
