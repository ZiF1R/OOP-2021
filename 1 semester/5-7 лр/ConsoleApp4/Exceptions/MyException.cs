using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Exceptions
{
    public class MyException : Exception
    {
        public string ErrorClass { get; set; }

        public MyException(string message, string errorClass) : base(message)
        {
            this.ErrorClass = errorClass;
        }
    }
}
