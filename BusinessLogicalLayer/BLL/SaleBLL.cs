using BusinessLogicalLayer.Extentions;
using Common;
using DataAccessLayer.DAL;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogicalLayer.BLL
{
    public class SaleBLL
    {
        private readonly SaleDAL _saleDAL;
        public SaleBLL()
        {
            _saleDAL = new SaleDAL();
        }
        //valida a venda e depois insere 
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
        //verifica todas as validações
        private Response Validate(Sale sale)
        {
            Validator validator = new Validator();
            ValidateClientId(sale.ClientID, validator);
            ValidateTotalValute(sale.TotalValue, validator);

            return validator.Validate();
        }

        //valida o item de venda
        public  Response ValidateSaleItem(SaleItem saleItem)
        {
            Validator validator = new Validator();
            ValidateProductId(saleItem.ProductID, validator);
            ValidateQuantity(saleItem.Quantity.ToString(), validator);
            ValidatePrice(saleItem.UnityPrice, validator);

            Response result = validator.Validate();

            return result;
            
        }

        //valida o id do cliente
        private void ValidateClientId(int clientId, Validator validator)
        {
            if (clientId <= 0)
            {
                validator.AddError("Cliente precisa ser informado!");
            }
        }

        //valida o valor total
        private void ValidateTotalValute(double totalValue, Validator validator)
        {
            if (totalValue <= 0)
            {
                validator.AddError("O valor total precisa ser informado e maior que zero!");
            }
        }

        //valida o id do produto
        private void ValidateProductId(int id, Validator validator)
        {
            if (id == 0 || (id.ToString().IsNullOrWhiteSpace()))
            {
                validator.AddError("Produto precisa ser adicionado!");
            }
        }

        //valida a quantidade
        private void ValidateQuantity(string quantity, Validator validator)
        {
            char[] quantityChar = quantity.ToCharArray();
            if (quantity.IsNullOrWhiteSpace())
            {
                validator.AddError("Quantidade do produto precisa ser informada!");
            }
            else if (quantityChar.Any(x => char.IsLetter(x)))
            {
                validator.AddError("A quantidade deve conter apenas números");
            }
            else if (Convert.ToInt32(quantity) <= 0)
            {
                validator.AddError("Quantidade do produto deve ser maior que zero!");
            }
        }

        //valida o preço
        private void ValidatePrice(double price, Validator validator)
        {
            
            if (price <= 0)
            {
                validator.AddError("Preço do produto deve ser maior que zero!");
            }
        }

        //retorna a venda de acordo com o id
        public QueryResponse<Sale> GetById(int id)
        {
            return _saleDAL.GetById(id);
        }

        //retorna uma lista de vendas de acordo com o id do cliente
        public QueryResponse<List<Sale>> GetByClientId(int id)
        {
            return _saleDAL.GetByClientId(id);
        }

        //retorna uma lista de itens de venda de acordo com o id da venda

        public QueryResponse<List<SaleItem>> GetBySaleId(int id)
        {
            return _saleDAL.GetBySaleId(id);
        }
    }
}
