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

        //Verifica se a stringbuilder _erros está vazia ou não
        public void AddError(string error)
        {
            if (error.HasValue())
                _errors.AppendLine(error);
        }

        //retorna a resposta dependendo se o comprimento de _erros for maior que zero
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


