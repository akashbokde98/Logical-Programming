using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Numbers to Reverse: ");
            long N = long.Parse(Console.ReadLine());
            long rmd;
            long reverse = 0;
            while(N!=0)
            {
                rmd = N % 10;
                reverse = reverse * 10 + rmd;
                N = N / 10;

            }
            Console.WriteLine("Reverse: " + reverse);

        }
    }
}
