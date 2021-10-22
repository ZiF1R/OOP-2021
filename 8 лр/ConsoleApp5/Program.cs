using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArray<int> arrayInt = new MyArray<int>(new []{ 1, 2, 3, 4 }, author: "ZiF1R", organisation: "BSTU");
            MyArray<double> arrayDouble = new MyArray<double>(new[] { 1.1, 2.2, 3.3, 4.4 });

            arrayInt.Add(5);
            arrayDouble.Add(3.1);

            arrayInt.Show();
            arrayDouble.Show();

            arrayInt.Remove(2);
            arrayDouble.Remove(0);

            Console.WriteLine();

            arrayInt.Show();
            arrayDouble.Show();

            MyArray<GeometricFigure> arrayClass = new MyArray<GeometricFigure>(
                new GeometricFigure[] { new GeometricFigure(12, 32), new GeometricFigure(4, 14) });

            arrayClass.Add(new GeometricFigure(6, 2));

            Console.ReadKey();
        }
    }
}
