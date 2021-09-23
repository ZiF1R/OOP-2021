using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    // ** Вариант 2 **

    //  Создать класс Airline: Cодержит : Пункт назначения,
    //  Номер рейса, Тип самолета, Время вылета, Дни недели.
    //  Свойства и конструкторы должны обеспечивать проверку
    //  корректности.

    //  Создать массив объектов.Вывести:
    //  a) список рейсов для заданного пункта назначения;
    //  b) список рейсов для заданного дня недели;

    class Airline
    {
        private string destination;
        private int flightNumber;
        private string planeType;
        private string day;
        private (int hours, int minutes) departureTime;

        public string Destination
        {
            get => destination;
            set
            {
                destination = value;
            }
        }

        public int FlightNumber
        {
            get => flightNumber;
            set
            {
                if (value.ToString().Length == 6)
                    flightNumber = value;
                else
                    throw new Exception("Номер должен содержать 6 цифр!");
            }
        }

        public string PlaneType
        {
            get => planeType;
            set
            {
                string[] planeTypes = { "Passenger", "Battle", "Cargo" };
                if (planeTypes.Contains(value))
                    planeType = value;
                else
                    throw new Exception("Тип самолета может быть Пассажирский, Боевой или Грузовой!");
            }
        }

        public string Day
        {
            get => day.ToString();
            set
            {
                string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sanday" };

                if (daysOfWeek.Contains(value))
                    day = value;
                else
                    throw new Exception("Введите корректный день недели!");
            }
        }

        public (int hours, int minutes) DepartureTime
        {
            get => departureTime;
            set
            {
                if (
                    (value.hours >= 0 && value.hours < 24) &&
                    (value.minutes >= 0 && value.minutes < 60)
                )
                    departureTime = value;
                else
                    throw new Exception("Введите корректное время!");
            }
        }

        static Airline()
        {
            Console.WriteLine("Start working with Airline!\n");
        }

        private Airline(string planeType)
        {
            destination = "";
            flightNumber = 0;
            PlaneType = planeType;
            day = "";
            departureTime = (0, 0);
        }

        public Airline()
        {
            destination = "";
            flightNumber = 0;
            planeType = "";
            day = "";
            departureTime = (0, 0);
        }

        public Airline(
            string destination = "", int flightNumber = 0, string planeType = "",
            string dayOfWeek = "", int hours = 0, int minutes = 0
            )
        {
            Destination = destination;
            FlightNumber = flightNumber;
            PlaneType = planeType;
            Day = dayOfWeek;
            DepartureTime = (hours, minutes);
        }
    }
}
