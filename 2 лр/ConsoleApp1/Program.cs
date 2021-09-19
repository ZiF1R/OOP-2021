using System;
using System.Text;
using System.Linq;

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



            //* 3. Массивы

            // a) Создайте целый двумерный массив и выведите его на консоль в
            //    отформатированном виде(матрица). 

            int[,] matrix = new int[3, 3] {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 },
            };

            Console.WriteLine("\n- Matrix:\n");
            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                    Console.Write(String.Format("{0,3}", matrix[row, column]));
                Console.WriteLine();
            }


            // b) Создайте одномерный массив строк. Выведите на консоль его
            //    содержимое, длину массива. Поменяйте произвольный элемент
            //    (пользователь определяет позицию и значение)
            string[] strs = {
                "<first str>",
                "<second str>",
                "<third str>"
            };

            Console.Write("\n- Array of strings: ");
            foreach (string st in strs)
                Console.Write(st + " ");

            Console.WriteLine(" Length: " + strs.Length);

            Console.Write("\n Please, enter position of element for change: ");
            int pos = Int32.Parse(Console.ReadLine()) - 1;
            Console.Write(" Please, enter new value: ");
            string newVal = Console.ReadLine();

            if (pos < strs.Length && pos > -1) strs[pos] = newVal;

            Console.Write("\n- Changed array: ");
            foreach (string st in strs)
                Console.Write(st + " ");
            Console.WriteLine("\n");


            // c) Создайте ступечатый (не выровненный) массив вещественных
            //    чисел с 3-мя строками, в каждой из которых 2, 3 и 4 столбцов 
            //    соответственно. Значения массива введите с консоли.
            double[][] steppedArr = new double [3][];
            steppedArr[0] = new double[2];
            steppedArr[1] = new double[3];
            steppedArr[2] = new double[4];

            for (int row = 0; row < steppedArr.Length; row++)
                for (int column = 0; column < steppedArr[row].Length; column++)
                {
                    Console.Write($"Enter element [{row}][{column}]: ");
                    steppedArr[row][column] = Double.Parse(Console.ReadLine());
                }

            Console.WriteLine("\n- Stepped array:\n");
            for (int row = 0; row < steppedArr.Length; row++)
            {
                for (int column = 0; column < steppedArr[row].Length; column++)
                    Console.Write($" {steppedArr[row][column]} ");
                Console.WriteLine();
            }


            // d) Создайте неявно типизированные переменные для хранения
            //    массива и строки.
            var strVal = "hello world!";
            var arrVal = steppedArr[2];



            //* 4. Кортежи

            // a) Задайте кортеж из 5 элементов с типами int, string, char, ulong.
            // b) Сделайте именование его элементов
            // c) Выведите кортеж на консоль целиком и выборочно (1, 3, 4 элементы)

            (int intVal, string strVal, char charVal, ulong ulongVal) tuple = (213, "string", 'a', 1234567);

            Console.Write("\n- Tuple: " + tuple);
            Console.WriteLine($" ({tuple.Item1}, {tuple.Item3}, {tuple.Item4})");


            // d) Выполните распаковку кортежа в переменные.
            (var q, var w, var e, var r) = tuple;
            Console.WriteLine($"\n- Tuple unboxing: ({q}, {w}, {e}, {r})");


            // e) Сравните два кортежа.
            (int intVal, string strVal, char charVal, ulong ulongVal) tuple1 = (213, "string", 'a', 1234567);
            Console.WriteLine($"\n- Tuple compare: {(tuple.Equals(tuple1) ? "Equal" : "Not equal")}");



            //* 5. Создайте локальную функцию в main и вызовите ее. Формальные
            //     параметры функции – массив целых и строка. Функция должна вернуть
            //     кортеж, содержащий: максимальный и минимальный элементы массива,
            //     сумму элементов массива и первую букву строки

            (int, int, int, char) func(int[] arr, string st)
            {
                return (arr.Max(), arr.Min(), arr.Sum(), st.First());
            }

            int[] array = { 1, 2, 3, 4, 5 };
            Console.WriteLine("\n- Function call: " + func(array, "Hello world!"));

            Console.ReadLine();
        }
    }
}
