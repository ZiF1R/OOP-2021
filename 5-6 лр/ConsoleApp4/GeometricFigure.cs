using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp4.Exceptions;

namespace ConsoleApp4
{
    //  > Геометрическая фигура, Круг, Прямоугольник
    //  > Управление (интерфейс с методами show, input, resize и т.д.)
    //  > Элемент управления, Checkbox, Radiobutton, Button


    //             # Лабораторная работа 6 #
    //  Создать UI из имеющихся фигур и элементов управления.

    //  Вывести список всех кнопок, подсчитать общее количество
    //  элементов на UI, найти площадь занимаемую всеми элментами

    public abstract class GeometricFigure
    {
        private double height;
        private double width;
        public double square;

        protected static int objCount = 0;

        public int ObjCount
        {
            get => objCount;
        }

        public double Height
        {
            get => height;
            set
            {
                if (value >= 0) height = value;
                else throw new FigureException("Height can't be less than 0!", value);
            }
        }

        public double Width
        {
            get => width;
            set
            {
                if (value >= 0) width = value;
                else throw new FigureException("Width can't be less than 0!", value);
            }
        }

        public GeometricFigure(double height = 0, double width = 0)
        {
            this.Height = height;
            this.Width = width;
            objCount++;
        }
        

        // methods

        public virtual string getClassName()
        {
            return "GeometricFigure";
        }

        public abstract void rotateBy90Degree();


        // override methods

        public override string ToString()
        {
            return $"Height: {this.Height}\nWidth: {this.Width}";
        }

        public override bool Equals(object obj)
        {
            GeometricFigure tmp = obj as GeometricFigure;
            if (this.Width == tmp.Width && this.Height == tmp.Height)
                return true;
            return false;
        }
    }
}
