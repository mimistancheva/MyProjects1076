using System;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Периметър и лице на правоъгълник
            double h, a;
            Console.WriteLine("Énter h:");
            h = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a:");
            a = double.Parse(Console.ReadLine());

            double P, S;
            P = 2 * a + 2 * h;
            Console.WriteLine("Периметърът на правоъгълника е = {0}", P);
            S = a * h;
            Console.WriteLine("Лицето на правоъгълника е  = {0}", S);
        }
    }
}
