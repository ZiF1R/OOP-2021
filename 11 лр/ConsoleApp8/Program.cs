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

            Console.ReadKey();
        }
    }
}
