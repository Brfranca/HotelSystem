using BusinessLogicalLayer.Extentions;
using Common;
using System.Text;

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


