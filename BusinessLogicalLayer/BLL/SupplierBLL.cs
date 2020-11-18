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
    public class SupplierBLL
    {
        private readonly SupplierDAL _supplierDAL;

        public SupplierBLL()
        {
            _supplierDAL = new SupplierDAL();
        }

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

        public Response Delete(Supplier supplier)
        {
            Response resultDelete = _supplierDAL.Delete(supplier);
            if (!resultDelete.Success)
                return resultDelete;

            return Response.CreateSuccess("Fornecedor removido com sucesso!");
        }


        public QueryResponse<List<Supplier>> GetAll()
        {
            return _supplierDAL.GetAll();
        }

        public QueryResponse<Supplier> GetById(int id)
        {
            return _supplierDAL.GetById(id);
        }

        public QueryResponse<Supplier> GetByCnpj(string cnpj)
        {
            return _supplierDAL.GetByCnpj(cnpj);
        }

        public QueryResponse<Supplier> GetByCompanyName(string companyName)
        {
            return _supplierDAL.GetByCompanyName(companyName);
        }

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
