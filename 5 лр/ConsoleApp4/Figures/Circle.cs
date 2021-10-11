using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Figures
{
    public sealed partial class Circle : GeometricFigure, IManagement
    {
        public double square = 0;
        public double circumference = 0;
        public double radius = 0;
        public readonly int ID = objCount;
        public CenterCoordinates center;
        public ConsoleColor color;

        public struct CenterCoordinates
        {
            public readonly double x;
            public readonly double y;

            public CenterCoordinates(double x = 0, double y = 0)
            {
                this.x = x;
                this.y = y;
            }

            public void getCoordinates()
            {
                Console.WriteLine($"Coordinates of center: ({x}, {y})");
            }
        }


        // Constructors

        public Circle()
        {
            this.Width = 0;
            this.Height = 0;
            this.center = new CenterCoordinates();
            this.color = ConsoleColor.White;
        }

        public Circle(double height, ConsoleColor color = ConsoleColor.White) : base(height)
        {
            this.radius = height / 2.0;
            this.square = Math.Round(Math.PI * Math.Pow(radius, 2));
            this.circumference = Math.Round(2 * Math.PI * radius);
            this.center = new CenterCoordinates(height / 2, height / 2);
            this.color = color;
        }


        // methods

        public void show()
        {
            Console.ForegroundColor = this.color;
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
            Console.ResetColor();
        }

        public void resize(double height = 0, double width = 0)
        {
            this.Height = height;
            this.radius = height / 2.0;
            this.square = Math.Round(Math.PI * Math.Pow(radius, 2));
            this.circumference = Math.Round(2 * Math.PI * radius);
            this.center = new CenterCoordinates(height / 2, height / 2);
        }
    }
}
