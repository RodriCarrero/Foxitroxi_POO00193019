﻿using System;

namespace AddNumbers
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int a = 0, b = 0;

            Console.WriteLine("Enter a value for a: "); 
            a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter a value for b: ");
            b = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"multiplying {a} * {b} subtracting {MultNumbers(a, b)} ");
        }

        public static int MultNumbers(int a, int b)
        {
            return a * b;
        }
    }
}
