using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Figures
{
    public sealed class Circle : GeometricFigure, IManagement
    {
        public double square = 0;
        public double circumference = 0;
        public double radius = 0;

        public Circle()
        {
            this.Width = 0;
            this.Height = 0;
        }

        public Circle(double height) : base(height)
        {
            this.radius = height / 2.0;
            this.square = Math.Round(Math.PI * Math.Pow(radius, 2));
            this.circumference = Math.Round(2 * Math.PI * radius);
        }

        public void show()
        {
            for (int i = 1; i < (int)radius * 2 + 1; i += 2)
            {
                int strWidth = (int)Math.Ceiling((double)((int)radius * 2 - i) / 2.0);
                Console.WriteLine("".PadLeft(strWidth, ' ').PadRight(strWidth + i, '0'));
            }
            for (int i = (int)radius * 2 + 1; i > 0; i -= 2)
            {
                int strWidth = (int)Math.Ceiling((double)((int)radius * 2 - i) / 2.0);
                Console.WriteLine("".PadLeft(strWidth, ' ').PadRight(strWidth + i, '0'));
            }
        }

        public void resize(double height = 0, double width = 0)
        {
            this.Height = height;
            this.radius = height / 2.0;
            this.square = Math.Round(Math.PI * Math.Pow(radius, 2));
            this.circumference = Math.Round(2 * Math.PI * radius);
        }

        public void input()
        {

        }


        // override methods

        public override string getClassName()
        {
            return "Circle";
        }

        public override string ToString()
        {
            return $"{"".PadLeft(12, '-')} INFO {"".PadLeft(12, '-')}\n" +
                $"Class: {this.getClassName()}\n" +
                $"Radius: {this.radius}\n" +
                $"Circumference: {this.circumference}\n" +
                $"Square: {this.square}\n" +
                $"{"".PadLeft(30, '-')}";
        }
    }
}
