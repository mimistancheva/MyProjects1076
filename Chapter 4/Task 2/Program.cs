using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Лице и обиколка на кръг
            double r;
            double p = 3.14;
            r = double.Parse(Console.ReadLine());
            Console.WriteLine("P= {0}", 2 * p * r);
            Console.WriteLine("S= {0}", p * r * r);

        }
    }
}
