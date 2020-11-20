using BusinessLogicalLayer.Extentions;
using Common;
using DataAccessLayer.DAL;
using Entities;
using Entities.Entities;
using System.Collections.Generic;

namespace BusinessLogicalLayer.BLL
{
    public class ProductBLL
    {
        private readonly ProductDAL _productDAL;

        public ProductBLL()
        {
            _productDAL = new ProductDAL();
        }

        //valida e inserete na tabela
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

        //valida e atualiza a tabela
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

        //deleta um conjunto de dados na tabela
        public Response Delete(Product product)
        {
            Response resultDelete = _productDAL.Delete(product);
            if (!resultDelete.Success)
                return resultDelete;

            return Response.CreateSuccess("Produto removido com sucesso!");

        }

        //retorna um lista com todos os produtos
        public QueryResponse<List<Product>> GetAll()
        {
            return _productDAL.GetAll();
        }

        public QueryResponse<Product> GetById(int id)
        {
            return _productDAL.GetById(id);
        }

        //verifica todas as validações
        private Response Validate(Product product)
        {
            Validator validator = new Validator();
            ValidateName(product.Name, product.ID, validator);
            ValidateDescription(product.Description, product.ID, validator);
            ValidateNameDescription(product.Name, product.Description, product.ID, validator);
            ValidateSupplierID(product.SuppliersID, product.ID, validator);

            return validator.Validate();
        }

        //valida o nome do produto
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

        //valida a descrição do produto
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

        //valida a existencia de uma unica combinação de nome e descrição
        private void ValidateNameDescription(string name, string description, int id, Validator validator)
        {
            if (_productDAL.ExistName(name, id) && _productDAL.ExistDescription(description, id))
            {
                validator.AddError("Produto já cadastrado!");
            }
        }

        //valida o id do fornecedor
        private void ValidateSupplierID(List<int> supplierID, int id, Validator validator)
        {
            if (supplierID.Count == 0)
            {
                validator.AddError("Pelo menos um fornecedor precisa ser informado!");
            }
        }

        //retorna uma lista de supplier_product de acordo com o id do produto

        public QueryResponse<List<Supplier_Product>> GetByProductId(int id)
        {
            return _productDAL.GetByProductId(id);
        }

        //retorna uma lista de supplier_product de acordo com o id do fornecedor
        public QueryResponse<List<Supplier_Product>> GetBySupplierId(int id)
        {
            return _productDAL.GetBySupplierId(id);
        }

    }
}
