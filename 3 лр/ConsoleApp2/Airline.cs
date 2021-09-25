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

    partial class Airline
    {
        public readonly int id = objCount - 1;
        private static int objCount = 0;
        private string destination;
        private int? flightNumber;
        private string planeType;
        private string day;
        private (int? hours, int? minutes) departureTime;

        public const string departureLocation = "Minsk";

        public int ObjCount
        {
            get => objCount;
        }

        public string Destination
        {
            get => destination;
            set
            {
                destination = value;
            }
        }

        public int? FlightNumber
        {
            get => flightNumber;
            set
            {
                if (value.ToString().Length == 6 || value == null)
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
                if (planeTypes.Contains(value) || value  == null)
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

                if (daysOfWeek.Contains(value) || value == null)
                    day = value;
                else
                    throw new Exception("Введите корректный день недели!");
            }
        }

        public (int? hours, int? minutes) DepartureTime
        {
            get => departureTime;
            set
            {
                if (
                    (value.hours >= 0 && value.hours < 24) &&
                    (value.minutes >= 0 && value.minutes < 60) ||
                    (value.minutes == null && value.minutes == null)
                )
                    departureTime = value;
                else
                    throw new Exception("Введите корректное время!");
            }
        }



        // *CONSTRUCTORS*

        static Airline()
        {
            Console.WriteLine("Start working with Airline!\n");
        }

        private Airline(string planeType)
        {
            destination = null;
            flightNumber = null;
            PlaneType = planeType;
            day = null;
            departureTime = (null, null);

            objCount++;
        }

        public Airline()
        {
            destination = null;
            flightNumber = null;
            planeType = null;
            day = null;
            departureTime = (null, null);

            objCount++;
        }

        public Airline(
            string destination = null, int? flightNumber = null, string planeType = null,
            string dayOfWeek = null, int? hours = null, int? minutes = null
            )
        {
            Destination = destination;
            FlightNumber = flightNumber;
            PlaneType = planeType;
            Day = dayOfWeek;
            DepartureTime = (hours, minutes);

            objCount++;
        }



        // *METHODS*

        public static void getInfo()
        {
            Console.WriteLine("Created {0} object(s) of class Airline.\n", objCount);
        }

        public static Airline[] FindByDestination(ref Airline[] arr, string destination)
        {
            return arr.Where(el => el.destination == destination).ToArray();
        }

        public static Airline[] FindByDayOfWeek(ref Airline[] arr, string dayOfWeek)
        {
            return arr.Where(el => el.day == dayOfWeek).ToArray();
        }
    }

    partial class Airline
    {
        public override bool Equals(object obj)
        {
            Airline temp = obj as Airline;

            if (temp != null)
            {
                if (
                    temp.destination == this.destination && temp.flightNumber == this.flightNumber &&
                    temp.day == this.day && temp.planeType == this.planeType && temp.departureTime == this.departureTime
                )
                    return true;
                else return false;
            }
            else return false;
        }

        public override string ToString()
        {
            return $"{"".PadLeft(20, '-')}\n" +
                $"{Airline.departureLocation}-{this.Destination}\n" +
                $"{this.planeType} №{this.flightNumber}\n" +
                $"{this.day} {this.departureTime.hours}:{this.departureTime.minutes}\n" +
                $"{"".PadLeft(20, '-')}\n";
        }

        public override int GetHashCode()
        {
            return this.id;
        }
    }
}
