using BusinessLogicalLayer.Extentions;
using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer
{
    public class Validator
    {
        private StringBuilder _errors;
        public Validator()
        {
            _errors = new StringBuilder();
        }

        public void AddError(string error)
        {
            if (error.HasValue())
                _errors.AppendLine(error);
        }

        public Response Validate()
        {
            if (_errors.Length == 0)
            {
                return Response.CreateSuccess();
            }
            return Response.CreateFailure(_errors.ToString());
        }
    }
}


