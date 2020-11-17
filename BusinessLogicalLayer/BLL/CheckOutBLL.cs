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
        private readonly CheckOutDAL _checkOutDAL;
        private readonly CheckInBLL _checkInBLL;
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

            Response response = _checkInBLL.GetById(checkOut.CheckInID);

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
