using System;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //* 1. Типы

            // a) Определите переменные всех возможных примитивных типов
            // С# и проинициализируйте их
            bool b = true;
            byte by = 16;
            char ch = 'a';
            string str = "hello world!";
            decimal dec = -123456789;
            double db = 3.4e-3;
            float fl = -3.4e38f;
            int i = 2147483647;
            long l = -9223372036854775808;
            sbyte sby = -128;
            short sh = 32767;
            uint ui = 0;
            ulong ul = 18446744073709551615;
            ushort ush = 65535;


            // b) Выполните 5 операций явного и 5 неявного приведения.

                // явное
            int newInt = (int)db;
            double newDouble = Double.Parse("2,3");
            short newShort = System.Convert.ToInt16(newInt);
            float newFloat = (float)newDouble;
            bool newBool = bool.Parse("false");

                // неявное
            long newLong = newInt;
            db = i;
            db = sh;
            ul = ui;
            db = fl;


            // c) Выполните упаковку и распаковку значимых типов.
            double a = 3.2;
            Object obj = a; //упаковка
            double c = (double)obj; //распаковка


            // d) Продемонстрируйте работу с неявно типизированной переменной.
            var v1 = "Hello";
            var v2 = 123;

            Console.WriteLine($"v1: {v1.GetType()}\nv2: {v2.GetType()}\n");


            // e) Продемонстрируйте пример работы с Nullable переменной.
            bool? flag = null;
            flag = true;



            //* 2. Строки

            // a) Объявите строковые литералы. Сравните их.
            string str1 = "Hello", str2 = "hello";
            string compare = str1 == str2 ? "equal" : "not equal";

            Console.WriteLine($"- Compare: strings '{str1}' and '{str2}' are {compare}\n");


            // b) Создайте три строки на основе String. Выполните: сцепление,
            //    копирование, выделение подстроки, разделение строки на слова,
            //    вставки подстроки в заданную позицию, удаление заданной
            //    подстроки.

            string s1 = "Lorem ipsum dolor sit amet, ",
                s2 = "consectetur adipiscing elit",
                s3 = "<copied value>";

            //* сцепление
            string result = String.Concat(s1, s2);
            Console.WriteLine("- Concat: " + result);

            //* разделение строки на слова
            Console.WriteLine("\n- Split:");

            string[] words = result.Split(' ');
            foreach (string word in words)
                Console.WriteLine($"    <{word}>");

            //* вставки подстроки в заданную позицию
            result = result.Insert(10, "<inserted value>");
            Console.WriteLine("\n- Insert: " + result);

            //* удаление заданной подстроки
            result = result.Remove(10, 16);
            Console.WriteLine("\n- Remove: " + result);

            //* выделение подстроки
            Console.WriteLine("\n- Substring: " + result.Substring(0, 17));

            //* копирование
            char[] dest = { 'T', 'h', 'e', ' ', 'i', 'n', 'i', 't', 'i', 'a', 'l', ' ',
                'a', 'r', 'r', 'a', 'y',  ' ', ' ', 'i', 'n', 'i', 't', 'i', 'a', 'l', ' ',
                'a', 'r', 'r', 'a', 'y'};
            s3.CopyTo(0, dest, 4, s3.Length);
            Console.Write("\n- Copy: ");
            Console.WriteLine(dest);


            // c) Создайте пустую и null строку. Продемонстрируйте что можно выполнить с такими строками
            string password = "", passwordConfirm = null;

            Console.Write("\n- Empty and null str: ");
            if (
                password.Length != 0 && passwordConfirm.Length != 0 &&
                password == passwordConfirm
            ) Console.WriteLine("Success!");
            else Console.WriteLine("Something go wrong!");


            // d) Создайте строку на основе StringBuilder. Удалите определенные
            //    позиции и добавьте новые символы в начало и конец строки
            StringBuilder strBld = new StringBuilder("Lorem ipsum dolor sit amet.");
            strBld.Remove(5, 5);
            strBld.Insert(0, "<added to start>");
            strBld.Append("<added to end>");
            Console.WriteLine("\n- StringBuilder: " + strBld);

            Console.ReadLine();
        }
    }
}
