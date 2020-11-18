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
    public class CheckInBLL
    {
        private CheckInDAL _checkInDAL;
        public CheckInBLL()
        {
            _checkInDAL = new CheckInDAL();
        }

        public Response Register(CheckIn checkIn)
        {
            Response result = Validate(checkIn);
            if (!result.Success)
                return result;

            Response resultInsert = _checkInDAL.Insert(checkIn);
            if (!resultInsert.Success)
                return resultInsert;

            return Response.CreateSuccess("Check in realizado com sucesso!");
        }

        public Response Validate(CheckIn checkIn)
        {
            try
            {
                Validator validator = new Validator();
                //verificar se precisa passar o checkInID como parametro para update
                ValidateClientID(checkIn.ClientID, validator);
                ValidateRoomID(checkIn.RoomID, validator);
                ValidateEntryDate(checkIn.EntryDate, validator);
                ValidateDepartureDate(checkIn.DepartureDate, validator);
                ValidateRoomPrice(checkIn.RoomPrice, validator);

                return validator.Validate();
            }
            catch (Exception erro)
            {
                return Response.CreateFailureException("Erro na validação do check in, contate o administrador.", erro);
            }
        }

        private void ValidateRoomPrice(double roomPrice, Validator validator)
        {
            string price = roomPrice.ToString();
            if (price.IsNullOrWhiteSpace())
            {
                validator.AddError("Preço diário do quarto deve ser informado!");
            }
            else if (roomPrice == 0)
            {
                validator.AddError("Preço diário do quarto deve ser informado!");
            }
        }

        private void ValidateDepartureDate(DateTime departureDate, Validator validator)
        {
            if (departureDate == null)
            {
                validator.AddError("Data de saída deve ser informada!");
            }
            else if (departureDate.Date == DateTime.Today)
            {
                validator.AddError("Data de saída deve ser diferente da data do check in!");
            }
            else if (departureDate.Date < DateTime.Today)
            {
                validator.AddError("Data de saída deve ser depois da data do check in!");
            }
        }

        private void ValidateEntryDate(DateTime entryDate, Validator validator)
        {
            if (entryDate == null)
            {
                validator.AddError("Data de entrada deve ser informada!");
            }
            else if (entryDate.Date != DateTime.Today)
            {
                validator.AddError("Data de entrada deve corresponder à data atual!");
            }
        }

        private void ValidateRoomID(int roomID, Validator validator)
        {
            string room = roomID.ToString();
            if (room.IsNullOrWhiteSpace())
            {
                validator.AddError("Quarto deve ser informado!");
            }
            else if (roomID == 0)
            {
                validator.AddError("Quarto deve ser informado!");
            }
        }
        private void ValidateClientID(int clientID, Validator validator)
        {
            string client = clientID.ToString();
            if (client.IsNullOrWhiteSpace())
            {
                validator.AddError("Cliente deve ser informado!");
            }
            else if (clientID == 0)
            {
                validator.AddError("Cliente deve ser informado!");
            }
        }

        public QueryResponse<CheckIn> GetById(int id)
        {
            return _checkInDAL.GetById(id);
        }
    }
}
