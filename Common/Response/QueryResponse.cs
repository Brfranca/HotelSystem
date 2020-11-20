using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class QueryResponse<T> : Response
    {
        public T Data { get; set; }

        //cria resposta de sucesso 
        public static QueryResponse<T> CreateSuccess(T data, string message = "")
        {
            return new QueryResponse<T>
            {
                Success = true,
                Message = message,
                Data = data
            };
        }

        //cria resposta de erro de acordo com uma exceção
        public static new QueryResponse<T> CreateFailureException(string message, Exception error)
        {
            return new QueryResponse<T>
            {
                Success = false,
                Message = message,
                ExceptionError = error.Message,
                StackTrace = error.StackTrace
            };
        }
        //cria o sucesso com algum determinado id
        public static new QueryResponse<T> CreateSuccess(string message = "", int id = 0)
        {
            return new QueryResponse<T> { Success = true, Message = message, GeneratedId = id };
        }

        //cria a resposta de erro
        public static new QueryResponse<T> CreateFailure(string message)
        {
            return new QueryResponse<T> { Success = false, Message = message };
        }
    }
}
