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

        public int ID = objCount - 1;
        public static int objCount = 0;

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
        

        // methods

        public virtual string getClassName()
        {
            return "GeometricFigure";
        }


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

        public override int GetHashCode()
        {
            return this.ID;
        }
    }
}
