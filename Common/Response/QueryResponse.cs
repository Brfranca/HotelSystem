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

        public static QueryResponse<T> CreateSuccess(T data, string message = "")
        {
            return new QueryResponse<T>
            {
                Success = true,
                Message = message,
                Data = data
            };
        }

        public static new QueryResponse<T> CreateFailureException(string message, Exception error)
            => (QueryResponse<T>)Response.CreateFailureException(message, error);

        public static new QueryResponse<T> CreateSuccess(string message = "")
            => (QueryResponse<T>)Response.CreateSuccess(message);

        public static new QueryResponse<T> CreateFailure(string message)
            => (QueryResponse<T>)Response.CreateFailure(message);
    }
}
