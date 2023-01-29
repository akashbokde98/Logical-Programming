using System;

namespace Perfect_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number To Check Perfect Number or Not: ");
            int N = int.Parse(Console.ReadLine());
            int result = 0;

            for (int i = 1; i < N; i++)
            {
                if (N % i == 0)
                {
                    result += i;
                }
            }
            
            if (result == N)
            {
                Console.WriteLine(N + " is a Perfect Number.");
            }
            else
            {
                Console.WriteLine(N + " is Not a Perfect Number.");
            }

        }
    }
}
