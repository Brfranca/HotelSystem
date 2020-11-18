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

        public double CalculateTotalValue(CheckIn checkIn, DateTime dtNow)
        {
            return CalculateRoomFeed(dtNow, checkIn) + CalculateTotalSale(checkIn);
        }

        public  double CalculateTotalSale(CheckIn checkIn)
        {
            QueryResponse<List<Sale>> responseSale = _saleBLL.GetByClientId(checkIn.ClientID);
            double totalSales = responseSale.Data.Sum(x => x.TotalValue);
            return totalSales;
        }

        public  double CalculateRoomFeed(DateTime dtNow, CheckIn checkIn)
        {
            TimeSpan duration = dtNow.Subtract(checkIn.EntryDate);

            double payment = checkIn.RoomPrice * Math.Ceiling(duration.TotalDays);

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
