using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            myArray arr1 = new myArray(new []{ 1, 2, 3 }, author: "ZiF1R", organisation: "BSTU");
            myArray arr2 = new myArray(new []{ 3, 2, 1, 3, 2, 1 });
            Console.WriteLine("> Time of creating arr2: {0}\n", arr1.date.Time);

            Console.WriteLine("> arr1 + arr2 = {0}", arr1 + arr2);
            Console.WriteLine("> arr1 - arr2 = {0}", arr1 - arr2);
            Console.WriteLine("> arr1 != arr2 = {0}", arr1 != arr2);
            Console.WriteLine("> arr1 contains 1 = {0}", arr1 > 1);
            Console.WriteLine("> Sum of arr1 elements = {0}", arr1.Sum());
            Console.WriteLine("> Delete vowels from string '{0}' = {1}", "Hello world!", "Hello world!".RemoveVowels());
            Console.WriteLine("> Remove first five elements from arr2 = {0}", arr2.RemoveFirstFive());

            Console.ReadKey();
        }
    }
}
