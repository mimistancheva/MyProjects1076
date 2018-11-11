using System;

namespace Task_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 35; // 00100011
            int p = 6;
            int i = 1; // 00000001
            int mask = i << p;
            Console.WriteLine((n & mask) != 0 ? 1 : 0);
        }
    }
}
