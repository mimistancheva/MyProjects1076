using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int num;
            Console.Write("Enter your number here : ");
            num = int.Parse(Console.ReadLine());
            if (num % 35 == 0)
            {

                bool newBool = true;
                Console.WriteLine(newBool);
                Console.WriteLine("Числото се дели на 5 и 7!");
            }
            else
            {
                bool newBool = false;
                Console.WriteLine(newBool);
                Console.WriteLine("Числото не се дели на 5 и 7!");
            }
        }
    }
}