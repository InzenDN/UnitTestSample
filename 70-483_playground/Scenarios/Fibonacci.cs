using System;
using System.Collections.Generic;
using System.Threading;

namespace _70_483_playground
{
    class Fibonacci
    {
        public static void Main(string[] args)
        {
            CalcFibonacci(0, 1, 1, 100);
        }

        public static void CalcFibonacci(long a, long b, int counter, int length)
        {
            if(counter <= length)
            {
                Thread.Sleep(100);
                Console.WriteLine($"{a}");
                CalcFibonacci(b, a + b, counter + 1, length);
            }
        }
    }
}
