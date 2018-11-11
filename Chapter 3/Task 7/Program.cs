using System;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double kilo;
            Console.WriteLine("Enter kg : ");
            kilo = double.Parse(Console.ReadLine());
            double lr;
            lr = kilo - (kilo * 0.17);
            Console.WriteLine("Your kilos on the Moon : {0}", lr);
            Console.ReadLine();
        }
    }
}
