using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    //  > Геометрическая фигура, Круг, Прямоугольник
    //  > Управление (интерфейс с методами show, input, resize и т.д.)
    //  > Элемент управления, Checkbox, Radiobutton, Button

    public class GeometricFigure
    {
        public double height;
        public double width;
        public Controls controls;

        public double Height
        {
            get => height;
            set
            {
                if (value >= 0) height = value;
                else throw new Exception("Height can't be less than 0!");
            }
        }

        public double Width
        {
            get => width;
            set
            {
                if (value >= 0) width = value;
                else throw new Exception("Width can't be less than 0!");
            }
        }

        public GeometricFigure(double height = 0, double width = 0)
        {
            this.Height = height;
            this.Width = width;
        }
    }
}
