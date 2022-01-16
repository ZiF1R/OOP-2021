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
            Airline tmp1 = new Airline();
            Airline tmp2 = new Airline("Moscow", 654321, "Passenger", "Monday", 12, 12);
            Airline tmp3 = new Airline("Tokyo", 123456, "Passenger", "Friday", 3, 00);
            Airline tmp4 = new Airline("USA", 321642, "Cargo", "Wednesday", 21, 45);
            Airline tmp5 = new Airline("USA", 735179, "Cargo", "Monday", 9, 30);
            Airline[] arr = { tmp1, tmp2, tmp3, tmp4, tmp5 };

            Console.WriteLine("Type of Airline-class object: {0}\n" +
                "Compare: {1}\n" +
                "Call property / method: tmp2.DepartureTime = {2}; tmp2.GetHashCode() = {3}\n",
                tmp1.GetType(), tmp4.Equals(tmp5), tmp2.DepartureTime, tmp2.GetHashCode());

            Airline.getInfo();

            foreach (Airline plane in Airline.FindByDayOfWeek(ref arr, "Monday"))
                Console.WriteLine(plane);

            foreach (Airline plane in Airline.FindByDestination(ref arr, "USA"))
                Console.WriteLine(plane);


            var anonymousAirline = new
            {
                id = 213,
                destination = "Mexico",
                flightNumber = 416377,
                planeType = "Passenger",
                day = "Tuesday",
                departureTime = (hours: 7, minutes: 30),
                departureLocation = "Moscow"
            };

            Console.WriteLine(anonymousAirline);

            Console.ReadKey();
        }
    }
}
