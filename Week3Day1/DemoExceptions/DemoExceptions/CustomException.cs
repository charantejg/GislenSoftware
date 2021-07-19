using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoExceptions
{
    public class CustomException: Exception
    {
        public string ErrorCode { get; set; }
        public string Message { get; set; }
        public CustomException(string message, string errorCode, Exception exception): base(message, exception)
        {
            ErrorCode = errorCode;
            Message = message;
        }

    }

}
