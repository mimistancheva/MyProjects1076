using System;

namespace Task_11
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;

            Console.Write("Enter number: ");
            int length = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= length; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
