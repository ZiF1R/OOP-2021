using System;
using System.Collections; // for ArrayList
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Создать необобщенную коллекцию ArrayList. 
            ArrayList array = new ArrayList();

            //a. Заполните ее 5-ю случайными целыми числами
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
                array.Add(rnd.Next(0, 100));

            //b. Добавьте к ней строку
            //c.Добавьте объект типа Student
            //d.Удалите заданный элемент
            Student student1 = new Student("Alex", 2);
            array.Add("new string");
            array.Add(student1);
            array.Remove("new string");

            //e. Выведите количество элементов и коллекцию на консоль.
            Console.WriteLine("> Length of ArrayList: {0}", array.Count);
            foreach (var item in array)
                Console.WriteLine(item);

            //f. Выполните поиск в коллекции значения
            Console.WriteLine("> Find element in collection: {0}", array[array.IndexOf(student1)]);

            Console.ReadKey();
        }
    }
}
