using System;

namespace Fibonacci_Series
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 9;
            Console.WriteLine(Fibonacci(n));
        }

        static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            int c = 0;

            for(int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c;
        }
    }
}
