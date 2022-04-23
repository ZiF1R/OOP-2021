using _10_lw.MVVM.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _10_lw.MVVM.ViewModels
{
    class StudentViewModel : INotifyPropertyChanged
    {
        public Student student;

        public StudentViewModel(Student student)
        {
            this.student = student;
        }

        public string Name
        {
            get => student.Name;
            set
            {
                student.Name = value;
                OnPropertyChanged("Name");
            }
        }

        public string Surname
        {
            get => student.Surname;
            set
            {
                student.Surname = value;
                OnPropertyChanged("Surname");
            }
        }

        public string Patronimic
        {
            get => student.Patronimic;
            set
            {
                student.Patronimic = value;
                OnPropertyChanged("Patronimic");
            }
        }

        public Discipline ActiveDiscipline
        {
            get => student.ActiveDiscipline;
            set
            {
                student.ActiveDiscipline = value;
                OnPropertyChanged("ActiveDiscipline");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
