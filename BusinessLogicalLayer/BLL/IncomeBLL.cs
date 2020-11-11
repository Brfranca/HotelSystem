﻿using BusinessLogicalLayer.Extentions;
using Common;
using DataAccessLayer.DAL;
using Entities;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private Response UpdatePrice(Income income)
        {
            foreach (var item in income.IncomeItems)
            {
                Product product = new ProductBLL().GetById(item.ProductID).Data;

                double stockDouble = Convert.ToDouble(product.Stock);
                double quantityDouble = Convert.ToDouble(item.Quantity);
                double totalDouble = Convert.ToDouble(product.Stock + item.Quantity);
                double currentPrice = stockDouble * product.Price;
                double newPrice = quantityDouble * (item.UnityPrice * 1.5);

               item.UnityPrice = (currentPrice + newPrice) / totalDouble;

                Response response = _incomeDAL.UpdatePrice(income);
                if (!response.Success)
                    return response;
            }

            return Response.CreateSuccess("Operação efetuada com sucesso!");
        }


        public Response Update(Income income)
        {
            Response result = Validate(income);
            if (!result.Success)
                return result;

            Response resultUpdate = _incomeDAL.Update(income);
            if (!resultUpdate.Success)
                return resultUpdate;

            return Response.CreateSuccess("Entrada de produtos atualizada com sucesso!");
        }

        public Response Delete(Income income)
        {
            Response resultDelete = _incomeDAL.Delete(income);
            if (!resultDelete.Success)
                return resultDelete;

            return Response.CreateSuccess("Entrada removida com sucesso!");

        }

        private Response Validate(Income income)
        {
            Validator validator = new Validator();
            ValidateSupplier(income.SupplierID, income.ID, validator);
            ValidateTotalValue(income.TotalValue, income.ID, validator);
            ValidateList(income.IncomeItems, income.ID, validator);
            
            return validator.Validate();
        }


        public QueryResponse<Income> GetById(int id)
        {
            return _incomeDAL.GetById(id);
        }

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

        private void ValidateQuantiy(int quantity, Validator validator)
        {
            if (quantity <= 0)
            {
                validator.AddError("O valor total da entrada deve ser maior que zero!");
            }
        }

        private void ValidatePrice(double price, Validator validator)
        {
            if (price <= 0)
            {
                validator.AddError("O valor total da entrada deve ser maior que zero!");
            }
        }

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


        private void ValidateList(List<IncomeItem> incomeItems, int id, Validator validator)
        {
            if (incomeItems.Count == 0)
            {
                validator.AddError("Um ou mais produtos devem ser adicionados!");
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
