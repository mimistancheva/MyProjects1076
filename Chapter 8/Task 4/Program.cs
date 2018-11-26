using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter decimal number: ");
    int deci = Int32.Parse(Console.ReadLine());
    Console.WriteLine("{0} to binary is {1}.",
        arg0: deci, arg1: deci.ToString(deci, 2));
        }
    }
}
