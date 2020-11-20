using BusinessLogicalLayer.Extentions;
using Common;
using DataAccessLayer.DAL;
using Entities;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.BLL
{
    public class RoomBLL
    {
        private readonly RoomDAL _roomDAL;
        public RoomBLL()
        {
            _roomDAL = new RoomDAL();
        }

        //valida e insere na tabela
        public Response Register(Room room)
        {
            Response result = Validate(room);
            if (!result.Success)
                return result;


            Response resultInsert = _roomDAL.Insert(room);
            if (!resultInsert.Success)
                return resultInsert;

            return Response.CreateSuccess("Quarto cadastrado com sucesso");
        }

        //valida e atualiza a tabela
        public Response Update(Room room)
        {
            Response result = Validate(room);
            if (!result.Success)
                return result;

            Response resultUpdate = _roomDAL.Update(room);
            if (!resultUpdate.Success)
                return resultUpdate;

            return Response.CreateSuccess("Quarto atualizado com sucesso!");
        }

        //deleta os dados de uma dada tabela de acordo com o quarto inserido como parametro
        public Response Delete(Room room)
        {
            Response resultDelete = _roomDAL.Delete(room);
            if (!resultDelete.Success)
                return resultDelete;

            return Response.CreateSuccess("Quarto removido com sucesso!");
        }

        //retorna uma lista com todos os quartos
        public QueryResponse<List<Room>> GetAll()
        {
            return _roomDAL.GetAll();
        }

        //retorna um quarto de acordo com o id
        public QueryResponse<Room> GetById(int id)
        {
            return _roomDAL.GetById(id);
        }

        //retorna um quarto de acordo com o numero
        public QueryResponse<Room> GetByNumber(string number)
        {
            return _roomDAL.GetByNumber(number);
        }

        //retorna uma lista de quartos de acordo com o status
        public QueryResponse<List<Room>> GetByAvailability(RoomStatus status)
        {
            return _roomDAL.GetByStatus(status);
        }

        // valida o quarto
        private Response Validate(Room room)
        {
            Validator validator = new Validator();
            ValidateRoomNumber(room.Number, room.ID, validator);
            ValidatePrice(room.PricePerDay, room.ID, validator);

            return validator.Validate();
        }

        //valida o numero do quarto
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

        //valida o preço do quarto

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
