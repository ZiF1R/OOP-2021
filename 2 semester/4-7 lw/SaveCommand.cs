using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace test
{
    public class SaveCommand
    {
        public static RoutedCommand Save { get; set; }

        static SaveCommand()
        {
            Save = new RoutedCommand("Save", typeof(MainWindow));
        }
    }
}
