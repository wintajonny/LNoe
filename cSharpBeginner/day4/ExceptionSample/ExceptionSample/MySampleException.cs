using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionSample
{

    public class MySampleException : Exception
    {
        public MySampleException() { }
        public MySampleException(string message) : base(message) { }
        public MySampleException(string message, Exception inner) : base(message, inner) { }


    }
}
