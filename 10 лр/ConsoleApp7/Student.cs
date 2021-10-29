using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Student
    {
        public string name;
        private uint course;

        public uint Course
        {
            get => course;
            set
            {
                if (value > 0) this.course = value;
                else this.course = 1;
            }
        }

        public Student(string name, uint course = 1)
        {
            this.name = name;
            this.Course = course;
        }

        public override string ToString()
        {
            return $"\nStudent: {this.name}\n" +
                $"Course: {this.course}\n";
        }
    }
}
