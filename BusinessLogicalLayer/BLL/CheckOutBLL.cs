﻿using Common;
using DataAccessLayer.DAL;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.BLL
{
    public class CheckOutBLL
    {
        private CheckOutDAL _checkOutDAL;
        private CheckInBLL _checkInBLL;
        private SaleBLL _saleBLL;
        public CheckOutBLL()
        {
            _checkOutDAL = new CheckOutDAL();
            _checkInBLL = new CheckInBLL();
            _saleBLL = new SaleBLL();
        }
        public Response Insert(CheckOut checkOut)
        {
            Response resultValidate = Validate(checkOut);
            if (!resultValidate.Success)
                return resultValidate;

            Response resultInsert = _checkOutDAL.Insert(checkOut);
            if (!resultInsert.Success)
                return resultInsert;

            return Response.CreateSuccess("CheckOut realizado com sucesso!");
        }

        public double CalculateTotalValue(CheckOut checkOut)
        {

            checkOut.TotalValue = CalculateTotalSale(checkOut.CheckInID) + CalculateRoomFeed(checkOut);

            return checkOut.TotalValue; 

        }

        private double CalculateTotalSale(int checkInId)
        {
            QueryResponse<List<Sale>> responseSale = _saleBLL.GetByClientId(checkInId);
            double totalSales = responseSale.Data.Sum(x => x.TotalValue);
            return totalSales;
        }

        private double CalculateRoomFeed(CheckOut checkOut)
        {
            QueryResponse<CheckIn> response = _checkInBLL.GetById(checkOut.CheckInID);
            TimeSpan duration = checkOut.ExitDay.Subtract(response.Data.EntryDate);
            double payment = 0.0;
            if (checkOut.ExitDay.Hour > 12)
            {
                payment = response.Data.RoomPrice * Math.Ceiling(duration.TotalDays);
            }
            else
            {
                payment = response.Data.RoomPrice * duration.TotalDays;
            }
            return payment;
        }

        private Response Validate(CheckOut checkOut)
        {
            Validator validator = new Validator();
            ValidateCheckIn(checkOut.CheckInID, validator);
            ValidateTotalValue(checkOut.TotalValue, validator);
            return validator.Validate();

        }

        private void ValidateCheckIn(int id, Validator validator)
        {
            if (id == 0)
            {
                validator.AddError("CheckIn precisa ser informado!");
            }
        }

        private void ValidateTotalValue(double totalValue, Validator validator)
        {
            if (totalValue == 0)
            {
                validator.AddError("O preço total precisa ser informado!");
            }
        }
        
    }
}
