using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    interface IManagement
    {
        void show();
        void resize(double height = 0, double width = 0);
        void rotateBy90Degree();
    }
}
