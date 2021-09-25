using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Airline wqq = new Airline();
            Airline t = new Airline("Moscow", 654321, "Passenger", "Monday", 12, 12);
            Airline t1 = new Airline("Tokyo", 123456, "Passenger", "Friday", 3, 00);
            Airline t2 = new Airline("Berlin", 321642, "Cargo", "Wednesday", 21, 45);
            Airline t3 = new Airline("USA", 735179, "Cargo", "Monday", 9, 30);
            Airline[] arr = { t, t1, t2, t3 };

            foreach (Airline plane in Airline.FindByDayOfWeek(ref arr, "Monday"))
                Console.WriteLine(plane);
            Console.WriteLine(t.ObjCount);

            Console.ReadLine();
        }
    }
}
