using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class myArray
    {
        public int[] array;


        // constructors

        public myArray()
        {
            this.array = null;
        }

        public myArray(int[] arr)
        {
            array = arr;
        }

        public int this[int i]
        {
            get => this.array[i];
            set => this.array[i] = value;
        }

        //methods

        public void Add(int number)
        {
            this.array = this.array.Append(number).ToArray();
        }

        // operators overload

        public static myArray operator +(myArray arr1, myArray arr2)
        {
            return new myArray(arr1.array.Concat(arr2.array).ToArray());
        }

        public static myArray operator -(myArray arr1, myArray arr2)
        {
            int[] result = new int[Math.Max(arr1.array.Length, arr2.array.Length)];

            if (arr1.array.Length < arr2.array.Length)
            {
                for (int i = 0; i < arr1.array.Length; i++)
                    result[i] = Math.Abs(arr1.array[i] - arr2.array[i]);
                for (int i = arr1.array.Length; i < arr2.array.Length; i++)
                    result[i] = Math.Abs(arr2.array[i]);
            }
            else
            {
                for (int i = 0; i < arr2.array.Length; i++)
                    result[i] = Math.Abs(arr1.array[i] - arr2.array[i]);
                for (int i = arr2.array.Length; i < arr1.array.Length; i++)
                    result[i] = Math.Abs(arr1.array[i]);
            }

            return new myArray(result);
        }

        public static bool operator ==(myArray arr1, myArray arr2)
        {
            if (arr1.array.Length != arr2.array.Length) return false;
            else
                for (int i = 0; i < arr1.array.Length; i++)
                    if (arr1.array[i] != arr2.array[i])
                        return false;

            return true;
        }

        public static bool operator !=(myArray arr1, myArray arr2)
        {
            if (arr1.array.Length != arr2.array.Length) return true;
            else
                for (int i = 0; i < arr1.array.Length; i++)
                    if (arr1.array[i] != arr2.array[i])
                        return true;

            return false;
        }

        public static bool operator >(myArray arr, int element)
        {
            return arr.array.Contains(element);
        }

        public static bool operator <(myArray arr, int element)
        {
            return arr.array.Contains(element);
        }

        public override string ToString()
        {
            string result = "{ ";
            for (int i = 0; i < this.array.Length; i++)
            {
                if (i + 1 != this.array.Length) result += $"{this.array[i]}, ";
                else result += $"{this.array[i]} ";
            }
            result += "}";

            return result;
        }
    }
}
