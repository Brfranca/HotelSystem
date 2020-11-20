using BusinessLogicalLayer.Extentions;
using Common;
using DataAccessLayer.DAL;
using Entities;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;

namespace BusinessLogicalLayer.BLL
{
    public class IncomeBLL
    {
        private readonly IncomeDAL _incomeDAL;
        public IncomeBLL()
        {
            _incomeDAL = new IncomeDAL();
        }

        //valida o income, atualiza o preço do produto e insere na tabela de income
        public Response Register(Income income)
        {
            Response result = Validate(income);
            if (!result.Success)
                return result;

            using (TransactionScope scope = new TransactionScope())
            {
                Response resultPrice = UpdatePrice(income);
                if (!resultPrice.Success)
                    return resultPrice;

                Response resultInsert = _incomeDAL.Insert(income);
                if (!resultInsert.Success)
                    return resultInsert;

                scope.Complete();
            }

            return Response.CreateSuccess("A entrada foi cadastrada com sucesso!");
        }

        //atualiza o preço do produto
        private Response UpdatePrice(Income income)
        {
            foreach (var item in income.IncomeItems)
            {
                Product product = new ProductBLL().GetById(item.ProductID).Data;

                double stockDouble = Convert.ToDouble(product.Stock);
                double quantityDouble = Convert.ToDouble(item.Quantity);
                double totalDouble = Convert.ToDouble(product.Stock + item.Quantity);
                double currentPrice = stockDouble * product.Price;
                double profit = (item.Profit / 100) + 1.0; 
                double newPrice = quantityDouble * (item.UnityPrice * profit);

                item.UnityPrice = (currentPrice + newPrice) / totalDouble;

                Response response = _incomeDAL.UpdatePrice(income);
                if (!response.Success)
                    return response;
            }

            return Response.CreateSuccess("Operação efetuada com sucesso!");
        }

        //verifica as validações
        private Response Validate(Income income)
        {
            Validator validator = new Validator();
            ValidateSupplier(income.SupplierID, income.ID, validator);
            ValidateTotalValue(income.TotalValue, income.ID, validator);
            ValidateListIncomeItems(income.IncomeItems, income.ID, validator);

            return validator.Validate();
        }

        //retorna um income de acordo com o id
        public QueryResponse<Income> GetById(int id)
        {
            return _incomeDAL.GetById(id);
        }

        //valida o fornecedor
        private void ValidateSupplier(int supplierID, int id, Validator validator)
        {
            string idString = supplierID.ToString();

            if (idString.IsNullOrWhiteSpace())
            {
                validator.AddError("O ID do fornecedor deve ser informado!");
            }
            else if (supplierID == 0)
            {
                validator.AddError("O ID do fornecedor deve ser informado!");
            }
        }

        //valida o valor total
        private void ValidateTotalValue(double totalValue, int id, Validator validator)
        {
            string totalValueString = totalValue.ToString();

            if (string.IsNullOrEmpty(totalValueString))
            {
                validator.AddError("O valor total da entrada deve ser informado!");
            }
            else if (totalValue <= 0)
            {
                validator.AddError("O valor total da entrada deve ser maior que zero!");
            }
        }

        //valida o incomeitems
        private void ValidateListIncomeItems(List<IncomeItem> incomeItems, int id, Validator validator)
        {
            if (incomeItems.Count == 0)
            {
                validator.AddError("Um ou mais produtos devem ser adicionados!");
            }
        }

        public Response ValidateIncomeItem(IncomeItem incomeitem)
        {
            Validator validator = new Validator();
            ValidatePrice(incomeitem.UnityPrice.ToString(), validator);
            ValidateQuantity(incomeitem.Quantity.ToString(), validator);
            ValidateProductId(incomeitem.ProductID, validator);
            ValidateProfit(incomeitem.Profit.ToString(), validator);

            Response result = validator.Validate();
            return result;
        }

        private void ValidatePrice(string price, Validator validate)
        {
            char[] priceChar = price.ToCharArray();

            if (price.IsNullOrWhiteSpace())
            {
                validate.AddError("O preço deve ser informado!");
            }
            else if (priceChar.Any(x => char.IsLetter(x)))
            {
                validate.AddError("O preço deve conter apenar números!");
            }
            else if (Convert.ToDouble(price) <= 0)
            {
                validate.AddError("O preço unitário deve ser maior que zero!");
            }
        }

        private void ValidateProfit(string profit, Validator validate)
        {
            char[] profitChar = profit.ToCharArray();

            if (profit.IsNullOrWhiteSpace())
            {
                validate.AddError("O lucro deve ser informado!");
            }
            else if (profitChar.Any(x => char.IsLetter(x)))
            {
                validate.AddError("O lucro deve conter apenar números!");
            }
            else if (Convert.ToDouble(profit) <= 0 || Convert.ToDouble(profit) > 100)
            {
                validate.AddError("O lucro deve ser maior que zero e no máximo cem!");
            }
        }

        public void ValidateQuantity(string quantity, Validator validate)
        {
            char[] quantityChar = quantity.ToCharArray();

            if (quantity.IsNullOrWhiteSpace())
            {
                validate.AddError("A quantidade deve ser informada!");
            }
            else if (quantityChar.Any(x => char.IsLetter(x)))
            {
                validate.AddError("Quantidade deve conter apenar números!");
            }
            else if (Convert.ToInt32(quantity) <= 0)
            {
                validate.AddError("A quantidade deve ser maior que zero!");
            }
        }

        private void ValidateProductId(int id, Validator validator)
        {
            if (id == 0)
            {
                validator.AddError("Nenhum produto selecionado!");
            }
        }

        public QueryResponse<List<Income>> GetAll()
        {
            return _incomeDAL.GetAll();
        }

        public QueryResponse<List<IncomeItem>> GetByIncomeId(int id)
        {
            return _incomeDAL.GetByIncomeId(id);
        }
    }
}
