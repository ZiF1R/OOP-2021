﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //* 1. Типы

            // a) Определите переменные всех возможных примитивных типов
            // С# и проинициализируйте их
            bool b = true;
            byte by = 16;
            char ch = 'a';
            string str = "hello world!";
            decimal dec = -123456789;
            double db = 3.4e-3;
            float fl = -3.4e38f;
            int i = 2147483647;
            long l = -9223372036854775808;
            sbyte sby = -128;
            short sh = 32767;
            uint ui = 0;
            ulong ul = 18446744073709551615;
            ushort ush = 65535;


            // b) Выполните 5 операций явного и 5 неявного приведения.

                // явное
            int newInt = (int)db;
            double newDouble = Double.Parse("2,3");
            short newShort = System.Convert.ToInt16(newInt);
            float newFloat = (float)newDouble;
            bool newBool = bool.Parse("false");

                // неявное
            long newLong = newInt;
            db = i;
            db = sh;
            ul = ui;
            db = fl;

        }
    }
}
