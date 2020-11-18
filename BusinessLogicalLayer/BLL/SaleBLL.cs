using BusinessLogicalLayer.Extentions;
using Common;
using DataAccessLayer.DAL;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.BLL
{
    public class SaleBLL
    {
        private readonly SaleDAL _saleDAL;

        public SaleBLL()
        {
            _saleDAL = new SaleDAL();
        }

        public Response Register(Sale sale)
        {
            Response result = Validate(sale);
            if (!result.Success)
                return result;

            Response resultInsert = _saleDAL.Insert(sale);
            if (!resultInsert.Success)
                return resultInsert;

            return Response.CreateSuccess("Venda efetuada com sucesso!");

        }

        private Response Validate(Sale sale)
        {
            Validator validator = new Validator();
            ValidateClientId(sale.ClientId, validator);
            ValidateTotalValute(sale.TotalValue, validator);

            return validator.Validate();
        }

        private Response ValidateSaleItem(int productId, string quantity)
        {
            Validator validator = new Validator();
            ValidateProductId(productId, validator);
            ValidateQuantity(quantity, validator);

            Response result = validator.Validate();
            if (result.Success)
            {
                result.ProductId = productId;
                result.ProductQuantity = Convert.ToInt32(quantity);
            }
            return result;
            
        }

        private void ValidateClientId(int clientId, Validator validator)
        {
            if (clientId <= 0)
            {
                validator.AddError("Cliente precisa ser informado!");
            }
        }

        private void ValidateTotalValute(double totalValue, Validator validator)
        {
            if (totalValue <= 0)
            {
                validator.AddError("O valor total precisa ser informado e maior que zero!");
            }
        }

        private void ValidateProductId(int id, Validator validator)
        {
            if (id == 0 || (id.ToString().IsNullOrWhiteSpace()))
            {
                validator.AddError("Produto precisa ser adicionado!");
            }
        }

        private void ValidateQuantity(string quantity, Validator validator)
        {
            char[] quantityChar = quantity.ToCharArray();
            if (quantity.IsNullOrWhiteSpace())
            {
                validator.AddError("Quantidade do produto precisa ser informada!");
            }
            else if (quantityChar.Any(x => char.IsLetter(x)))
            {
                validator.AddError("A quantidade deve conter apensar números");
            }
            else if (Convert.ToInt32(quantity) <= 0)
            {
                validator.AddError("Quantdade do produto deve ser maior que zero!");
            }
        }

        public Response GetById(int id)
        {
            return _saleDAL.GetById(id);
        }

        public QueryResponse<List<Sale>> GetByClientId(int id)
        {
            return _saleDAL.GetByClientId(id);
        }
    }
}
