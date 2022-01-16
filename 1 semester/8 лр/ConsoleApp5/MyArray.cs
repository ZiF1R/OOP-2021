using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp5.Interfaces;

namespace ConsoleApp5
{
    public partial class MyArray<T> : IArray<T>
    {
        public T[] array;
        public readonly Date date;
        public readonly Owner owner;

        // subclasses

        public class Owner
        {
            public int ID { get; }
            public string Author { get; }
            public string Organization { get; }

            public Owner(int id, string author, string organization)
            {
                this.ID = id;
                this.Author = author;
                this.Organization = organization;
            }
        }
        public class Date
        {
            public DateTime Time { get; }

            public Date()
            {
                Time = DateTime.Now;
            }
        }

        // constructors

        public MyArray()
        {
            this.array = new T[] { };
            this.date = new Date();
            this.owner = new Owner(0, "", "");
        }

        public MyArray(T[] arr, int id = 0, string author = "", string organisation = "")
        {
            array = arr;
            this.date = new Date();
            this.owner = new Owner(id, author, organisation);
        }


        // IArray<T> methods

        public void Show()
        {
            string result = "{ ";
            foreach (T item in this.array)
                result += $"{item}, ";
            result += "}";
            Console.WriteLine(result);
        }

        public void Add(T elem)
        {
            this.array = this.array.Append(elem).ToArray();
        }

        public void Remove(int index)
        {
            try
            {
                if (index >= this.array.Length || index < 0)
                    throw new Exception($"Index out of range (0, {this.array.Length - 1})");
                this.array = this.array.Where((el, i) => i != index).ToArray();
            }
            catch(Exception e)
            {
                Console.WriteLine($"RangeOutException: {e.Message}!");
            }
        }
    }
}
