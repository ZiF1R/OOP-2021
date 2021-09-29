using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    //                  Вариант 2

    //  Класс Одномерный массив. Дополнительно перегрузить
    //  следующие операции: - разность со скалярным значением;
    //  > проверка на вхождение элемента; != проверка на
    //  неравенство массивов; + объединение массивов

    //  Методы расширения:
    //  1) Удаление гласных из строки
    //  2) Удаление первых пяти элементов

    class myArray
    {
        public Array array;

        public myArray()
        {
            array = null;
        }

        public myArray(Array arr)
        {
            array = arr;
        }

        public static myArray operator +(myArray arr1, myArray arr2)
        {
            return new myArray(new[] { arr1, arr2 });
        }

        public static bool operator ==(myArray arr1, myArray arr2)
        {
            if (arr1.array.Length != arr2.array.Length) return false;
            else
                for (int i = 0; i < arr1.array.Length; i++)
                    if (
                        arr1.array.GetValue(i).ToString() != arr2.array.GetValue(i).ToString() ||
                        arr1.array.GetValue(i).GetType() != arr2.array.GetValue(i).GetType()
                    )
                        return false;

            return true;
        }

        public static bool operator !=(myArray arr1, myArray arr2)
        {
            if (arr1.array.Length != arr2.array.Length) return true;
            else
                for (int i = 0; i < arr1.array.Length; i++)
                    if (
                        arr1.array.GetValue(i).ToString() != arr2.array.GetValue(i).ToString() ||
                        arr1.array.GetValue(i).GetType() != arr2.array.GetValue(i).GetType()
                    )
                        return true;

            return false;
        }
    }
}
