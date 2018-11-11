using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 23;
            bool even = number % 2 == 0 ? true : false;
            Console.WriteLine("{0} is even? {1}", number, even);
        }
    }
}
