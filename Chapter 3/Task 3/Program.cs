﻿using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 45764;
            bool isSeven = (number / 100) % 10 == 7 ? true : false;
            int even = 0;
            Console.WriteLine("Third digit of {0} is 7", number, even);


        }
    }
}
