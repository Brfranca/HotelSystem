using BusinessLogicalLayer.Extentions;
using Common;
using DataAccessLayer.DAL;
using Entities;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.BLL
{
    public class ProductBLL
    {
        private readonly ProductDAL _productDAL;

        public ProductBLL()
        {
            _productDAL = new ProductDAL();
        }
        public Response Register(Product product)
        {
            Response result = Validate(product);
            if (!result.Success)
                return result;

            Response resultInsert = _productDAL.Insert(product);
            if (!resultInsert.Success)
                return resultInsert;

            return Response.CreateSuccess("O produto foi cadastrado com sucesso!");
            
        }

        public Response Update(Product product)
        {
            Response result = Validate(product);
            if (!result.Success)
                return result;

            Response resultUpdate = _productDAL.Update(product);
            if (!resultUpdate.Success)
                return resultUpdate;

            return Response.CreateSuccess("O produto atualizado com sucesso!");
        }

        public Response Delete(Product product)
        {
            Response resultDelete = _productDAL.Delete(product);
            if (!resultDelete.Success)
                return resultDelete;

            return Response.CreateSuccess("Produto removido com sucesso!");

        }

        public QueryResponse<List<Product>> GetAll()
        {
            return _productDAL.GetAll();
        }

        public QueryResponse<Product> GetById(int id)
        {
            return _productDAL.GetById(id);
        }

        private Response Validate(Product product)
        {
            Validator validator = new Validator();
            ValidateName(product.Name, product.ID, validator);
            ValidateDescription(product.Description, product.ID, validator);
            ValidateNameDescription(product.Name, product.Description, product.ID, validator);
            ValidateSupplierID(product.SuppliersID, validator);

            return validator.Validate();
        }

        private void ValidateName(string name, int id, Validator validator)
        {
            if (name.IsNullOrWhiteSpace())
            {
                validator.AddError("O nome do produto deve deve ser informado!");
            }
            else if (name.Length > 70)
            {
                validator.AddError("O nome do produto deve conter até 70 caracteres!");

            }
        }

        private void ValidateDescription(string description, int id, Validator validator)
        {
            if (description.IsNullOrWhiteSpace())
            {
                validator.AddError("A descrição do produto deve ser informada!");
            }
            else if (description.Length > 100)
            {
                validator.AddError("A descrição do produto deve conter até 100 caracteres");
            }
        }

        private void ValidateNameDescription(string name, string description, int id, Validator validator)
        {
            if (_productDAL.ExistName(name, id) && _productDAL.ExistDescription(description, id))
            {
                validator.AddError("Produto já cadastrado!");
            }
        }

        private void ValidateSupplierID(List<int> supplierID, Validator validator)
        {
            if (supplierID.Count == 0)
            {
                validator.AddError("Pelo menos um fornecedor precisa ser informado!");
            }
        }

        public QueryResponse<List<Supplier_Product>> GetAssociativeTable(int id)
        {
            return _productDAL.GetAssociativeTable(id);
        }

        
    }
}
