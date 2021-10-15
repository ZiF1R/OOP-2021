using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp4.Controls;
using ConsoleApp4.Figures;

namespace ConsoleApp4
{
    //3) Определить класс-Контейнер(указан в вариантах жирным шрифтом)
    //  для хранения разных типов объектов(в пределах иерархии) в виде
    //  списка или массива(использовать абстрактный тип данных).
    //  Классконтейнер должен содержать методы get и set для управления
    //  списком/массивом, методы для добавления и удаления объектов в
    //  список/массив, метод для вывода списка на консоль.

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

        public void ShowAllButtons()
        {
            for (int i = 0; i < this.array.Length; i++)
                if (this.array[i] is Button) Console.WriteLine(this.array[i]);
        }

        public int GetLength()
        {
            return array.Length;
        }
    }
}
