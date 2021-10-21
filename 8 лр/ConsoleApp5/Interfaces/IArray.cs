using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Interfaces
{
    interface IArray<T>
    {
        void Add(T elem);
        void Remove(int index);
        void Show();
    }
}
