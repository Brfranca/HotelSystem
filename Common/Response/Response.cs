using System;

namespace Common
{
    public class Response
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public string ExceptionError { get; set; }
        public string StackTrace { get; set; }
        public int Id { get; set; }

        public string GetAllMessages()
            => $"Message: {Message}. ExceptionError: {ExceptionError}. StackTrace: {StackTrace}";

        public static Response CreateSuccess(string message = "", int id = 0)
        {
            return new Response { Success = true, Message = message, Id = id };
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
