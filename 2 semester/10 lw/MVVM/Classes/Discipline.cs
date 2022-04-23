using _10_lw.MVVM.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_lw.MVVM
{
    class Discipline
    {
        public string Name { get; set; }
        public ushort Hours { get; set; }
        public Lector Lector { get; set; }
        public ushort ListenersCount { get; set; }

        public Discipline(string name, ushort hours, Lector lector, ushort listenersCount)
        {
            Name = name;
            Hours = hours;
            Lector = lector;
            ListenersCount = listenersCount;
        }
    }
}
