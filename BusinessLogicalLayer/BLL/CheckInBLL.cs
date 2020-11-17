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

        //public Response Register(CheckIn checkIn)
        //{

        //}

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

                return validator.Validate();
            }
            catch (Exception erro)
            {
                return Response.CreateFailureException("Erro na validação do check in, contate o administrador.", erro);
            }
        }

        private void ValidateDepartureDate(DateTime departureDate, Validator validator)
        {

        }

        private void ValidateEntryDate(DateTime entryDate, Validator validator)
        {
            throw new NotImplementedException();
        }

        private void ValidateRoomID(int roomID, Validator validator)
        {
            throw new NotImplementedException();
        }

        private void ValidateClientID(int clientID, Validator validator)
        {
            throw new NotImplementedException();
        }
    }
}
