using System;
using System.Dynamic;

namespace Common
{
    public class Response
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public string ExceptionError { get; set; }
        public string StackTrace { get; set; }
        public int GeneratedId { get; set; }
        public int ProductId { get; set; }
        public double ProductPrice { get; set; }
        public int ProductQuantity { get; set; }
        public double ProdcutProfit { get; set; }

        public string GetAllMessages()
            => $"Message: {Message}. ExceptionError: {ExceptionError}. StackTrace: {StackTrace}";

        public static Response CreateSuccess(string message = "", int id = 0)
        {
            return new Response { Success = true, Message = message, GeneratedId = id };
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
