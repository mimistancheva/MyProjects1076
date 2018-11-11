﻿using System;

namespace Task_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 2;
            bool isPrime = true;
            if (number > 2)
                for (int i = 2; i <= Math.Ceiling(Math.Sqrt(number)); ++i)
                {
                    if (number % i == 0) isPrime = false;
                }
            Console.WriteLine("{0} is prime?: {1}", number, isPrime);
        }
    }
}
