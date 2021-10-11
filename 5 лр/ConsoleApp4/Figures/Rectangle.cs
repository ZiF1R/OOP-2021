using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Figures
{
    public class Rectangle : GeometricFigure, IManagement
    {
        public double square = 0;
        public double diagonal = 0;
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

        public Rectangle()
        {
            this.Width = 0;
            this.Height = 0;
            this.center = new CenterCoordinates();
            this.color = ConsoleColor.White;
        }

        public Rectangle(double height, double width, ConsoleColor color = ConsoleColor.White) : base(height, width)
        {
            this.square = width * height;
            this.diagonal = Math.Round(Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2)));
            this.center = new CenterCoordinates(width / 2, height / 2);
            this.color = color;
        }


        // methods

        public void show()
        {
            Console.ForegroundColor = this.color;
            for (int i = 0; i < (int)Height; i++)
            {
                Console.WriteLine("".PadLeft((int)Math.Round(Width), '0'));
            }
            Console.ResetColor();
        }

        public void resize(double height = 0, double width = 0)
        {
            this.Height = height;
            this.Width = width;
            this.square = width * height;
            this.diagonal = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2));
            this.center = new CenterCoordinates(width / 2, height / 2);
        }


        // override methods

        public override void rotateBy90Degree()
        {
            (this.Height, this.Width) = (this.Width, this.Height);
        }

        void IManagement.rotateBy90Degree()
        {
            Console.WriteLine("IManagement.rotateBy90Degree()");
        }

        public override string getClassName()
        {
            return "Rectangle";
        }

        public override string ToString()
        {
            return $"{"".PadLeft(12, '-')} INFO {"".PadLeft(12, '-')}\n" +
                $"Class: {this.getClassName()}\n" +
                $"Height: {this.Height}\n" +
                $"Width: {this.Width}\n" +
                $"Square: {this.square}\n" +
                $"Diagonal: {this.diagonal}\n" +
                $"{"".PadLeft(30, '-')}";
        }

        public override int GetHashCode()
        {
            return this.ID;
        }
    }
}
