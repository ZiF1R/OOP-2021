using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Figures
{
    public partial class Circle
    {
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

        public override int GetHashCode()
        {
            return this.ID;
        }

        public override void rotateBy90Degree()
        {

        }
    }
}
