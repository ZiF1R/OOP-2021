using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Interfaces
{
    interface IArray<T>
    {
        T Add(T elem);
        T Remove(T elem);
        void Show();
    }
}
