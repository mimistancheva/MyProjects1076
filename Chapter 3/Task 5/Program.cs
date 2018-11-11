using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Площ на трапец
            double h, a, b;
            Console.WriteLine("Énter h:");
            h = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter b:");
            b = double.Parse(Console.ReadLine());

            double S;
            S = ((a + b) * h) / 2;
            Console.WriteLine("Площта на трапеца е = {0}", S);
            Console.ReadLine();
        }
    }
}
