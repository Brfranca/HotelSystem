using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Response
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public string ExceptionError { get; set; }
        public string StackTrace { get; set; }

        public string GetAllMessages()
            => $"Message: {Message}. ExceptionError: {ExceptionError}. StackTrace: {StackTrace}";

        public static Response CreateSuccess(string message = "")
        {
            return new Response { Success = true, Message = message };
        }

        public static Response CreateFailure(string message)
        {
            return new Response { Success = false, Message = message };
        }

        public static Response CreateFailureException(string message, Exception error)
        {
            return new Response
            {
                Success = false,
                Message = message,
                ExceptionError = error.Message,
                StackTrace = error.StackTrace
            };
        }
    }
}
