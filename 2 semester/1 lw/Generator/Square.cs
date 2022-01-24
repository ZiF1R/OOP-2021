using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_lw
{
    public class Square
    {
        public int EdgeSize { get; set; }

        public Square(int edgeSize = 0)
        {
            EdgeSize = edgeSize;
        }

        public override string ToString()
        {
            return $"Size of square: {this.EdgeSize}×{this.EdgeSize}";
        }
    }
}
