using BusinessLogicalLayer.Extentions;
using Common;
using DataAccessLayer.DAL;
using Entities.Entities;
using System;
using System.Collections.Generic;

namespace BusinessLogicalLayer.BLL
{
    public class ReservationBLL
    {
        private ReservationDAL _reservationDAL;
        public ReservationBLL()
        {
            _reservationDAL = new ReservationDAL();
        }

        //valida e insere na tabela
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

        //valida e atualiza a tabela
        public Response Update(Reservation reservation)
        {
            Response result = Validate(reservation);
            if (!result.Success)
                return result;

            Response resultInsert = _reservationDAL.Update(reservation);
            if (!resultInsert.Success)
                return resultInsert;

            return Response.CreateSuccess("Reserva atualizada com sucesso!");
        }

        //deleta uma dada reserva no banco de dados
        public Response Delete(Reservation reservation)
        {
            Response resultDelete = _reservationDAL.Delete(reservation);
            if (!resultDelete.Success)
                return resultDelete;

            return Response.CreateSuccess("Reserva removida com sucesso!");
        }

        //retorna uma lista de reservas que estão ativas
        public QueryResponse<List<Reservation>> GetByActiveState()
        {
            return _reservationDAL.GetByActiveState();
        }

        //verifica todas as validações 
        public Response Validate(Reservation reservation)
        {
            try
            {
                Validator validator = new Validator();

                ValidateClientID(reservation.ClientID, validator);
                ValidateRoomID(reservation.RoomID, validator);
                ValidateEntryDate(reservation.EntryDate, validator);
                ValidateDepartureDate(reservation.DepartureDate, reservation.EntryDate, validator);
                ValidateRoomPrice(reservation.RoomPrice, validator);

                return validator.Validate();
            }
            catch (Exception erro)
            {
                return Response.CreateFailureException("Erro na validação da reserva, contate o administrador.", erro);
            }
        }

        //valida o preço do quarto
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

        //valida a data de saída
        private void ValidateDepartureDate(DateTime departureDate, DateTime entryDate, Validator validator)
        {
            if (departureDate == null)
            {
                validator.AddError("Data de saída deve ser informada!");
            }
            else if (departureDate.Date == entryDate.Date)
            {
                validator.AddError("Data de saída deve ser diferente da data de entrada !");
            }
            else if (departureDate.Date <entryDate.Date)
            {
                validator.AddError("Data de saída deve ser depois da data de entrada!");
            }
        }

        //valida a data de entrada
        private void ValidateEntryDate(DateTime entryDate, Validator validator)
        {
            if (entryDate == null)
            {
                validator.AddError("Data de entrada deve ser informada!");
            }
            else if (entryDate.Date <= DateTime.Today)
            {
                validator.AddError("Data de entrada deve ser uma data futura!");
            }
        }

        //valida o id do quarto
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

        //valida o id do cliente
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

        //retorna uma reserva de acordo com o id
        public QueryResponse<Reservation> GetById(int id)
        {
            return _reservationDAL.GetById(id);
        }

        //retorna uma lista com todas as reservas
        public QueryResponse<List<Reservation>> GetAll()
        {
            return _reservationDAL.GetAll();
        }

        //verifica se um dado cliente já possui reserva
        public bool ExistClient(string clientId, int id = 0)
        {
            return _reservationDAL.ExistClient(clientId, id);
        }
    }
}
