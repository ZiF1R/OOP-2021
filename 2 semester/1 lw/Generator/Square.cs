using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_lw
{
    public class Square : IComparable
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

        public int CompareTo(object obj)
        {
            Square other = obj as Square;
            if (other == null) return -1;

            if (this.EdgeSize == other.EdgeSize) return 0;
            else if (this.EdgeSize > other.EdgeSize) return 1;
            else return -1;
        }
    }
}
