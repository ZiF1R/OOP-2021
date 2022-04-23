using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_lw.MVVM.Classes
{
    class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronimic { get; set; }
        public Discipline ActiveDiscipline { get; set; }

        public Student(string name, string surname, string patronimic, Discipline discipline = null)
        {
            Name = name;
            Surname = surname;
            Patronimic = patronimic;
            ActiveDiscipline = discipline;
        }
    }
}
