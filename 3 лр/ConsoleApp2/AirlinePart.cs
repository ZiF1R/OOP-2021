using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
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
