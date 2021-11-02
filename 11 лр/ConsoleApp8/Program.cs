using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {

            //1. Задайте массив типа string, содержащий 12 месяцев (June, July, May,
            //December, January ….). Используя LINQ to Object напишите запрос выбирающий
            //последовательность месяцев с длиной строки равной n, запрос возвращающий
            //только летние и зимние месяцы, запрос вывода месяцев в алфавитном порядке,
            //запрос считающий месяцы содержащие букву «u» и длиной имени не менее 4 - х..

            string[] arr = new string[]
                { 
                    "January",
                    "February",
                    "March",
                    "April",
                    "May",
                    "June",
                    "July",
                    "August",
                    "September",
                    "October",
                    "November",
                    "December"
                };

            Console.Write("> Enter the length of string which you want to find: ");
            int n = Convert.ToInt32(Console.ReadLine());
            var strQuery1 =
                from month in arr
                where month.Length == n
                select month;

            foreach (string month in strQuery1)
                Console.WriteLine(month);

            Console.WriteLine();
            var strQuery2 =
                from month in arr
                where (new[] { "January", "February", "June", "July", "August", "December" }.Contains(month))
                select month;

            Console.WriteLine("\n> Summer or winter months:\n");
            foreach (string month in strQuery2)
                Console.WriteLine(month);

            Console.WriteLine("\n> Sort by alphabet:\n");
            var strQuery3 =
                from month in arr
                orderby month
                select month;

            foreach (string month in strQuery3)
                Console.WriteLine(month);

            Console.WriteLine();
            var strQuery4 =
                from month in arr
                where (month.Contains('u'))
                select month;

            Console.WriteLine("\n> Months which contains letter 'u':\n");

            foreach (string month in strQuery4)
                Console.WriteLine(month);


            //2.Создайте коллекцию List<T> и параметризируйте ее типом (классом)
            //из лабораторной №3(при необходимости реализуйте нужные интерфейсы).
            List<myArray> arrays = new List<myArray>()
            {
                new myArray(new []{ 9, 2, 3, 4 }),
                new myArray(new []{ 4, 5, 1, 2 }),
                new myArray(new []{ 1, 5, 8, 2 }),
                new myArray(new []{ 0, 3, 7, 2 }),
                new myArray(new []{ 12, 1, 2, 7 }),
                new myArray(new []{ 8 }),
                new myArray(new []{ 4 }),
                new myArray(new []{ -4, 5, -8, 2 }),
                new myArray(new []{ 0, -7, -3, -1 }),
                new myArray(new []{ 4, -5, 9, -1 }),
                new myArray(new []{ 7, 6, 1 }),
                new myArray(new []{ 7, 6, 1, 4 }),
                new myArray(new []{ 4, -5, 9 })
            };


            //3.На основе LINQ сформируйте следующие запросы по вариантам.
            //При необходимости добавьте в класс T(тип параметра) свойства.

            // queries:
            //  стек с наименьшим / наибольшим верхним элементом;
            Console.WriteLine("\n> Arrays where first element is maximal or minimal:\n");
            var query1 =
                from array in arrays
                where (array.Max() == array[0] || array.Min() == array[0])
                select array;

            foreach (myArray array in query1)
                Console.WriteLine(array);


            //  список стеков, содержащих отрицательные элементы.
            Console.WriteLine("\n> Arrays with negative numbers:\n");
            var query2 =
                from array in arrays
                where (array.Where((el) => el < 0).Length > 0)
                select array;

            foreach (myArray array in query2)
                Console.WriteLine(array);


            //  Минимальный стек
            Console.WriteLine("\n> Minimal array:\n");
            var query3 =
                from array in arrays
                orderby (array.Sum())
                select array;

            Console.WriteLine(query3.First());


            //  Массив стеков длины 1 и 3
            Console.WriteLine("\n> Arrays where length is 1 or 3:\n");
            var query4 =
                from array in arrays
                where (array.Length() == 1 || array.Length() == 3)
                select array;

            foreach (myArray array in query4)
                Console.WriteLine(array);


            //  Первый стек с нулевым элементом
            Console.WriteLine("\n> First array with zero element:\n");
            var query5 =
                from array in arrays
                where (array.Contains(0))
                select array;

            Console.WriteLine(query5.First());


            //  Упорядоченный массив стеков по сумме элементов
            Console.WriteLine("\n> Order by sum:\n");
            var query6 =
                from array in arrays
                orderby (array.Sum())
                select array;

            foreach (myArray array in query6)
                Console.WriteLine(array);


            Console.ReadKey();
        }
    }
}
