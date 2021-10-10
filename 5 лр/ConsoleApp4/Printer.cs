using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public static class Printer
    {
        public static void IAmPrinting(GeometricFigure figure)
        {
            Console.WriteLine(figure.ToString());
        }
    }
}
