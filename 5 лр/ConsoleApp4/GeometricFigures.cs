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
        public double square;
        public int height;
        public int width;
        public Controls controls;
    }

    public class Circle : GeometricFigure, IManagement
    {

        public void show()
        {

        }

        public void resize()
        {

        }

        public void input()
        {

        }
    }
}
