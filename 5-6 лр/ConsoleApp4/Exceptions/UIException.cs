using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Exceptions
{
    public class UIException : MyException
    {
        public UIException(string message) : base(message, "UI") { }
    }
}
