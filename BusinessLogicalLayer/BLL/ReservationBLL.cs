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
    public class ReservationBLL
    {
        private ReservationDAL _reservationDAL;
        public ReservationBLL()
        {
            _reservationDAL = new ReservationDAL();
        }

        public Response Register(Reservation reservation)
        {
            Response result = Validate(reservation);
            if (!result.Success)
                return result;

            Response resultInsert = _reservationDAL.Insert(reservation);
            if (!resultInsert.Success)
                return resultInsert;

            return Response.CreateSuccess("Reserva realizada com sucesso!");
        }

        public Response Validate(Reservation reservation)
        {
            try
            {
                Validator validator = new Validator();

                ValidateClientID(reservation.ClientID, validator);
                ValidateRoomID(reservation.RoomID, validator);
                ValidateEntryDate(reservation.EntryDate, validator);
                ValidateDepartureDate(reservation.DepartureDate, validator);
                ValidateRoomPrice(reservation.RoomPrice, validator);

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

        public QueryResponse<List<CheckIn>> GetByActiveState()
        {
            return _reservationDAL.GetByActiveState();
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

        //public QueryResponse<CheckIn> GetById(int id)
        //{
        //    return _checkInDAL.GetById(id);
        //}

        //public QueryResponse<List<CheckIn>> GetAll()
        //{
        //    return _checkInDAL.GetAll();
        //}

    }
}
