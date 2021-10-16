using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    //  Создать UI из имеющихся фигур и элементов управления.
    //  Вывести список всех кнопок, подсчитать общее количество
    //  элементов на UI, найти площадь занимаемую всеми элментами

    public sealed class UI
    {
        public object[] array;

        public UI(params object[] arr)
        {
            this.array = arr;
        }

        public object this[int i]
        {
            get => array[i];
            set
            {
                if (value is GeometricFigure || value is Controller)
                    array.Append(value);
            }
        }


        // methods 

        public void Add(object elem)
        {
            this.array = array.Append(elem).ToArray();
        }

        public void Remove(int index)
        {
            this.array = this.array.Where((el, i) => i != index).ToArray();
        }

        public void Show()
        {
            for (int i = 0; i < this.array.Length; i++)
                Console.WriteLine(this.array[i]);
        }
    }
}
