using _10_lw.MVVM.Classes;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _10_lw.MVVM
{
    class DisciplineViewModel : INotifyPropertyChanged
    {
        public Discipline Discipline;

        public DisciplineViewModel(Discipline discipline)
        {
            Discipline = discipline;
        }

        public string Name
        {
            get => Discipline.Name;
            set
            {
                Discipline.Name = value;
                OnPropertyChanged("Name");
            }
        }

        public ushort Hours
        {
            get => (ushort)Discipline.Hours;
            set
            {
                Discipline.Hours = value;
                OnPropertyChanged("Hours");
            }
        }

        public Lector Lector
        {
            get => Discipline.Lector;
            set
            {
                Discipline.Lector = value;
                OnPropertyChanged("Lector");
            }
        }

        public ushort ListenersCount
        {
            get => Discipline.ListenersCount;
            set
            {
                Discipline.ListenersCount = value;
                OnPropertyChanged("ListenersCount");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
