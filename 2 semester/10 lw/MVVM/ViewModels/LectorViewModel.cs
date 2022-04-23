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
    class LectorViewModel : INotifyPropertyChanged
    {
        public Lector lector;

        public LectorViewModel(Lector lector)
        {
            this.lector = lector;
        }

        public string Name
        {
            get => lector.Name;
            set
            {
                lector.Name = value;
                OnPropertyChanged("Name");
            }
        }

        public string Surname
        {
            get => lector.Surname;
            set
            {
                lector.Surname = value;
                OnPropertyChanged("Surname");
            }
        }

        public string Patronimic
        {
            get => lector.Patronimic;
            set
            {
                lector.Patronimic = value;
                OnPropertyChanged("Patronimic");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
