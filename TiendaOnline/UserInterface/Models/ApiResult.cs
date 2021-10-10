using System;

namespace UserInterface.Models
{
    public class ApiResult
    {
        public Object data { get; set; } = null;
        public string message { get; set; }
        public Exception exception { get; set; }
        public ApiResult() { }
        public ApiResult(string Message, Exception Exceptions)
        {
            data = null; message = Message; exception = Exceptions;
        }
        public ApiResult(Object Data)
        {
            message = "Proceso satisfactorio";
            data = Data;
        }
    }
}
