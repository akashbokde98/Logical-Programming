using System;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Nmber to Check Prime Number: ");
            int number = int.Parse(Console.ReadLine());

            bool flag = false;
            for (int i = 2; i < number/2; i++)
            {
                if (number%2 == 0)
                {
                    flag = true;
                    break;
                }
            }
            if (flag == true)
            {
                Console.WriteLine("Number is not a Prime Number");
            }
            else
            {
                Console.WriteLine("Number is a Prime Number");
            }
        }
    }
}
