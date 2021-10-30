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
            Console.WriteLine();


            // 2. Создать обобщенную коллекцию в соответствии с вариантом задания и
            // заполнить ее данными, тип которых определяется вариантом задания(колонка – первый тип).

            Queue<int> q = new Queue<int>();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);
            q.Enqueue(5);

            //a. Вывести коллекцию на консоль
            foreach (int number in q)
                Console.WriteLine(number);

            //b. Удалите из коллекции n последовательных элементов
            Console.Write("\nEnter number of removed elements: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int length = q.Count;
            for (int i = 0; i < n && i < length; i++)
                q.Dequeue();

            Console.WriteLine();
            foreach (int number in q)
                Console.WriteLine(number);

            // c.Добавьте другие элементы(используйте все возможные методы
            // добавления для вашего типа коллекции).
            q.Append(1);
            q.Enqueue(2);

            //d. Создайте вторую коллекцию (см. таблицу) и заполните ее данными из первой коллекции.
            Dictionary<int, int> d = new Dictionary<int, int>();

            Console.ReadKey();
        }
    }
}
