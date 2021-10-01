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

    public class myArray
    {
        public int[] array;
        public readonly Date date;
        public readonly Owner owner;

        // subclasses

        public class Owner
        {
            public readonly int id;
            public readonly string author;
            public readonly string organization;

            public Owner(int id, string author, string organization)
            {
                this.id = id;
                this.author = author;
                this.organization = organization;
            }
        }
        public class Date
        {
            public readonly DateTime time;

            public Date()
            {
                time = DateTime.Now;
            }
        }


        // constructors

        public myArray()
        {
            this.array = null;
            this.date = new Date();
            this.owner = new Owner(0, "", "");
        }

        public myArray(int[] arr, int id = 0, string author = "", string organisation = "")
        {
            array = arr;
            this.date = new Date();
            this.owner = new Owner(id, author, organisation);
        }


        // operators overload

        public static myArray operator +(myArray arr1, myArray arr2)
        {
            return new myArray(arr1.array.Concat(arr2.array).ToArray());
        }

        public static bool operator ==(myArray arr1, myArray arr2)
        {
            if (arr1.array.Length != arr2.array.Length) return false;
            else
                for (int i = 0; i < arr1.array.Length; i++)
                    if (arr1.array[i] != arr2.array[i])
                        return false;

            return true;
        }

        public static bool operator !=(myArray arr1, myArray arr2)
        {
            if (arr1.array.Length != arr2.array.Length) return true;
            else
                for (int i = 0; i < arr1.array.Length; i++)
                    if (arr1.array[i] != arr2.array[i])
                        return true;

            return false;
        }

        public static bool operator >(myArray arr, int element)
        {
            return arr.array.Contains(element);
        }

        public static bool operator <(myArray arr, int element)
        {
            return arr.array.Contains(element);
        }

        public override string ToString()
        {
            string result = "{ ";
            foreach (int num in array)
                result += $"{num}, ";
            result += "}";

            return result;
        }
    }
}
