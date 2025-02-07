﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    static class StatisticOperations
    {
        public static int Sum(this myArray arr)
        {
            return arr.array.Sum();
        }

        public static int MaxMinDiff(this myArray arr)
        {
            return arr.array.Max() - arr.array.Min();
        }

        public static int Capacity(this myArray arr)
        {
            return arr.array.Length;
        }

        public static string RemoveVowels(this string str)
        {
            char[] vowels = { 'a', 'e', 'y', 'u', 'i', 'o', 'A', 'E', 'Y', 'U', 'I', 'O' };
            string result = "";
            for (int i = 0; i < str.Length; i++)
                if (!vowels.Contains(str[i])) result += str[i];

            return result;

            //Regex.Replace(str, "(?i)[aeyuio]", "");
        }

        public static myArray RemoveFirstFive(this myArray arr)
        {
            if (arr.array.Length <= 5) return new myArray(new int[] { });

            int[] result = new int[arr.array.Length - 5];
            for (int i = 5; i < arr.array.Length; i++)
                result[i - 5] = arr.array[i];

            return new myArray(result);
        }
    }
}
