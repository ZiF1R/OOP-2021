using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Figures
{
    public partial class Rectangle
    {
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
