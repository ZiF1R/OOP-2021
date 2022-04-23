using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_lw.MVVM.Classes
{
    class Lector
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronimic { get; set; }

        public Lector(string name, string surname, string patronimic)
        {
            Name = name;
            Surname = surname;
            Patronimic = patronimic;
        }
    }
}
