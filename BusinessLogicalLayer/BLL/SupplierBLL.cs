using BusinessLogicalLayer.Extentions;
using Common;
using DataAccessLayer.DAL;
using Entities;
using System;
using System.Collections.Generic;

namespace BusinessLogicalLayer.BLL
{
    public class SupplierBLL
    {
        private readonly SupplierDAL _supplierDAL;

        public SupplierBLL()
        {
            _supplierDAL = new SupplierDAL();
        }

        //Verifica a validação do fornecedor e depois insere da tabela 
        public Response Register(Supplier supplier)
        {
            supplier.CNPJ = supplier.CNPJ.RemoveMaskCNPJ();
            Response result = Validate(supplier);
            if (!result.Success)
                return result;

            Response resultInsert = _supplierDAL.Insert(supplier);
            if (!resultInsert.Success)
                return resultInsert;

            return Response.CreateSuccess("Fornecedor cadastrado com sucesso!");
        }

        //Verifica a validação do fornecedor e depois atualiza a tabela 
        public Response Update(Supplier supplier)
        {
            supplier.CNPJ = supplier.CNPJ.RemoveMaskCNPJ();
            Response result = Validate(supplier);
            if (!result.Success)
                return result;

            Response resultUpdate = _supplierDAL.Update(supplier);
            if (!resultUpdate.Success)
                return resultUpdate;

            return Response.CreateSuccess("Fornecedor atualizado com sucesso!");
        }

        //deleta os dados de um dado fornecedor na tabela
        public Response Delete(Supplier supplier)
        {
            Response resultDelete = _supplierDAL.Delete(supplier);
            if (!resultDelete.Success)
                return resultDelete;

            return Response.CreateSuccess("Fornecedor removido com sucesso!");
        }

        //retorna uma lista com todos os fornecedores
        public QueryResponse<List<Supplier>> GetAll()
        {
            return _supplierDAL.GetAll();
        }

        //retorna um fornecedor de acordo como o id
        public QueryResponse<Supplier> GetById(int id)
        {
            return _supplierDAL.GetById(id);
        }

        //retorna um fornecedor de acordo como o cnpj

        public QueryResponse<Supplier> GetByCnpj(string cnpj)
        {
            return _supplierDAL.GetByCnpj(cnpj);
        }

        //retorna um fornecedor de acordo como a razão social

        public QueryResponse<Supplier> GetByCompanyName(string companyName)
        {
            return _supplierDAL.GetByCompanyName(companyName);
        }

        //verifica todas as validações do fornecedor
        private Response Validate(Supplier supplier)
        {
            try
            {
                Validator validator = new Validator();
                ValidateCompanyName(supplier.CompanyName, validator);
                ValidateCnpj(supplier.CNPJ, supplier.ID, validator);
                ValidatePhone(supplier.Phone, validator);
                ValidateEmail(supplier.Email, supplier.ID, validator);
                ValidateContractName(supplier.ContactName, validator);

                return validator.Validate();
            }
            catch (Exception erro)
            {
                return Response.CreateFailureException("Erro na validação do fornecedor!", erro);
            }
        }

        //valida o email
        private void ValidateEmail(string email, int id, Validator validator)
        {
            if (email.IsNullOrWhiteSpace())
            {
                validator.AddError("E-mail deve ser informado");
            }
            else if (!email.IsValidEmail())
            {
                validator.AddError("E-mail informado não é válido!");
            }
            else if (_supplierDAL.ExistEmail(email, id))
            {
                validator.AddError("E-mail já cadastrado em nossa base de dados!");
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

        //valida o cnpj

        private void ValidateCnpj(string cnpj, int id, Validator validator)
        {
            if (cnpj.IsNullOrWhiteSpace())
            {
                validator.AddError("CNPJ deve ser informado!");
            }
            else if (!cnpj.IsValidCnpj())
            {
                validator.AddError("CNPJ inválido!");
            }
            else if (_supplierDAL.ExistCnpj(cnpj, id))
            {
                validator.AddError("CNPJ já cadastrado em nossa base da dados!");
            }
        }

        //valida o nome de contato
        private void ValidateContractName(string contactName, Validator validator)
        {
            if (contactName.IsNullOrWhiteSpace())
            {
                validator.AddError("Nome para contato deve ser informado!");
            }
            else if (!contactName.IsValidName())
            {
                validator.AddError("Nome para contato é inválido!");
            }
        }

        //valida a razao social
        private void ValidateCompanyName(string companyName, Validator validator)
        {
            if (companyName.IsNullOrWhiteSpace())
            {
                validator.AddError("Razão social deve ser informado!");
            }
            else if (!companyName.IsValidFullName())
            {
                validator.AddError("Razão social inválida!");
            }
        }
    }
}
