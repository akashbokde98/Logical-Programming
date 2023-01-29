using System;

namespace Coupon_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N Distinct Coupon Number: ");
            int N = int.Parse(Console.ReadLine());

            int couponCode = CouponNumbers(N);
            Console.WriteLine(couponCode);


        }

        static int CouponNumbers(int N)
        {
            Random rnd = new Random();
            int[] rndArray = new int[N];

            for (int i = 0; i < N; i++)
            {
                rndArray[i] = rnd.Next();

                //Console.WriteLine(rndArray[i]);
            }

            int randNum = CheckRandom(rndArray);
            return randNum;
        }

        static int CheckRandom(int[] rndArray)
        {
            int[] couponArray = new int[rndArray.Length];

            int i = 0;
            if (rndArray[i] != rndArray[1])
            {
                if (rndArray[i] != rndArray[2])
                {
                    if (rndArray[i] != rndArray[3])
                    {
                        if (rndArray[i] != rndArray[4])
                        {
                            couponArray[i] = rndArray[i];
                        }
                        else
                        {
                            Console.WriteLine("Occures Same Coupon Numbers.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Occures Same Coupon Numbers.");
                    }
                }
                else
                {
                    Console.WriteLine("Occures Same Coupon Numbers.");
                }

            }
            else
            {
                Console.WriteLine("Occures Same Coupon Numbers.");
            }

            i++;
            if (rndArray[i] != rndArray[2])
            {
                if (rndArray[i] != rndArray[3])
                {
                    if (rndArray[i] != rndArray[4])
                    {
                        couponArray[i] = rndArray[i];
                    }
                    else
                    {
                        Console.WriteLine("Occures Same Coupon Numbers.");
                    }
                }
                else
                {
                    Console.WriteLine("Occures Same Coupon Numbers.");
                }
            }
            else
            {
                Console.WriteLine("Occures Same Coupon Numbers.");
            }

            i++;
            if (rndArray[i] != rndArray[3])
            {
                if (rndArray[i] != rndArray[4])
                {
                    couponArray[i] = rndArray[i];
                }
                else
                {
                    Console.WriteLine("Occures Same Coupon Numbers.");
                }
            }
            else
            {
                Console.WriteLine("Occures Same Coupon Numbers.");
            }

            i++;//3
            if (rndArray[i] != rndArray[4])
            {
                couponArray[i] = rndArray[i];
            }
            else
            {
                Console.WriteLine("Occures Same Coupon Numbers.");
            }

            i++; //4
            if ((rndArray[i] != rndArray[0]) && (rndArray[i] != rndArray[1]) && (rndArray[i] != rndArray[2]) && (rndArray[i] != rndArray[3]));
            {
                couponArray[i] = rndArray[i];
            }
            else
            {
                Console.WriteLine("Occures Same Coupon Numbers.");
            }

            return couponArray;
        }

    }
}
