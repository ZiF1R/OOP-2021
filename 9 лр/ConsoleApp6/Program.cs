using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            User u1 = new User("Alex", "Dobriyan");
            User u2 = new User("Cheslav", "Linevich");
            User u3 = new User("Vlad", "Isakov");

            User.MoveHandler move = (int x, int y) => Console.WriteLine($"User was moved by ({x}, {y})");
            User.CompressHandler compress = (double coefficient) => Console.WriteLine($"User was compressed by {coefficient}");

            u1.MoveEvent += move;
            u2.MoveEvent += move;

            u1.CompressEvent += compress;
            u3.CompressEvent += compress;

            u1.Move(12, 23);
            u1.Move(-12, -3);
            u2.Move(2, 12);
            u3.Move(4, -5); // *

            u1.Compress(1.05);
            u3.Compress(2);

            Console.WriteLine("\n> User1:");
            u1.GetCurrentCompression();
            u1.GetCurrentPosition();

            Console.WriteLine("\n> User2:");
            u2.GetCurrentCompression();
            u2.GetCurrentPosition();

            Console.WriteLine("\n> User3:");
            u3.GetCurrentCompression();
            u3.GetCurrentPosition();


            // string methods

            string startStr = "  tHiS, is  A, teXT;   whITcH! tESts:    tHe. abiLItiEs?  OF mY;   fUncCTions    ";
            Action<string> CurrentString = (str) => Console.WriteLine(str);
            Func<string, string> stringOperations = User.RemoveExtraSpaces;

            Console.Write("> Action and Func:\n{0}", startStr);
            CurrentString(startStr = stringOperations(startStr));

            stringOperations += User.ToDefaultCase;
            CurrentString(startStr = stringOperations(startStr));

            stringOperations += User.RemovePunctuationMarks;
            CurrentString(startStr = stringOperations(startStr));

            stringOperations += User.RemoveVovels;
            CurrentString(startStr = stringOperations(startStr));

            stringOperations += User.GetFirstWord;
            CurrentString(startStr = stringOperations(startStr));

            Console.ReadKey();
        }
    }
}
