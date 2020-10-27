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
    class RoomBLL
    {
        private readonly RoomDAL _roomDAL;
        public Response Register(Room room)
        {
            Response result = Validate(room);
            if (!result.Success)
                return result;


            Response resultInsert = _roomDAL.Insert(room);
            if (!resultInsert.Success)
                return resultInsert;

            return Response.CreateSuccess("Quarto cadastrado com sucesso");
            //rever pq eu fico chamando o CreateSuccess se ele é chamado dentro do DbExecuter().Execute()
        }

        private Response Validate(Room room)
        {
            Validator validator = new Validator();
            ValidateRoomNumber(room.Number, room.ID, validator);
            ValidateFloor(room.RoomFloor, validator);
            ValidatePrice(room.PricePerDay, room.ID, validator);

            return validator.Validate();
        }

        private void ValidateRoomNumber(string number, int id, Validator validator)
        {
            if (_roomDAL.ExistNumber(number, id))
            {
                validator.AddError("Número de quarto já cadastrado");
            }
            else if (number.IsNullOrWhiteSpace())
            {
                validator.AddError("O número do quarto deve ser informado!");
            }
        }

        private void ValidateFloor(string floor, Validator validator)
        {
            if (floor.IsNullOrWhiteSpace())
            {
                validator.AddError("O andar do quarto deve ser informado!");
            }

            //Validar se o andar informado está de acordo com os andares que o prédio possui ou criar um enum?
        }

        private void ValidatePrice(double pricePerDay, int id, Validator validator)
        {
            string pricePerDayString = pricePerDay.ToString();
            if (pricePerDayString.IsNullOrWhiteSpace())
            {
                validator.AddError("O preço da diária deve ser informado!");
            }
        }
    }
}
