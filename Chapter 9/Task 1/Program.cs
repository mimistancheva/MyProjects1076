﻿using System;

namespace Task_1
{
    class Program
    {
        static void ReturnName(string name)
        {
            Console.WriteLine("Hello {0}", name);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter name: ");
            ReturnName(Console.ReadLine());
        }
    }
}
