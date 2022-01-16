using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Exceptions
{
    public class FigureException : MyException
    {
        public double ErrorValue { get; set; }

        public FigureException(string message, double errorValue)
            : base(message, "GeometricFigure")
        {
            this.ErrorValue = errorValue;
        }
    }
}
