using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Exceptions
{
    class UIOutOfRangeException : MyException
    {
        public int ErrorIndex { get; set; }

        public UIOutOfRangeException(string message, int errorIndex) : base(message, "UIOutOfRange")
        {
            this.ErrorIndex = errorIndex;
        }
    }
}
