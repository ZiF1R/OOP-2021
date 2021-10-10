using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp4.Figures;
using ConsoleApp4.Controls;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(13);
            Circle circle2 = new Circle(13);
            Rectangle rect = new Rectangle(5, 2);
            GeometricFigure figure = circle2 as GeometricFigure;

            Console.WriteLine("> Rectangle:\n");
            rect.show();

            rect.rotateBy90Degree();
            Console.WriteLine("\n\n> Rectangle after rotating:\n");
            rect.show();

            Console.WriteLine("\n> Circle1:\n");
            circle1.show();

            Console.WriteLine("\n> Figure as circle:\n\n{0}", figure.ToString());
            Console.WriteLine("\n> Is operator: {0}", rect is GeometricFigure);
            Console.WriteLine("\n> Circle equals: {0}", circle1.Equals(circle2));

            Console.WriteLine("\n> Before resize:\n\n{0}", circle2.ToString());
            circle2.show();
            circle2.resize(5);
            Console.WriteLine("\n> After resize:\n\n{0}", circle2.ToString());
            circle2.show();

            Console.WriteLine();
            Checkbox checkbox = new Checkbox(description: "new checkbox");
            Console.WriteLine(checkbox.IsActive);
            checkbox.Activate();
            Console.WriteLine(checkbox.IsActive);
            checkbox.Deactivate();
            Console.WriteLine(checkbox);

            Console.WriteLine("\n\n> Printer:\n");
            GeometricFigure[] arr = { circle1, circle2, rect };
            for (int i = 0; i < arr.Length; i++)
                Printer.IAmPrinting(arr[i]);

            Console.ReadKey();
        }
    }
}
