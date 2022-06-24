using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class CustomExecption : Exception
    {
        public string message;

        public enum ExceptionType
        {
            NULL_STRING, EMPTY_STRING, INVALID_STRING, NO_SUCH_CLASS, NO_SUCH_METHOD
        }

        public ExceptionType type;

        public CustomExecption(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}

