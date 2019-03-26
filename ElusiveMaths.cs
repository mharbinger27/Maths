using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maths
{
    public static class ElusiveMaths
    {
        public static void GoldbachsConjecture(int seconds)
        {
            Console.WriteLine("Goldbach's Conjecture:");
            Console.WriteLine("Any even number larger than 2 can be written as the sum of two prime numbers.");
            Console.WriteLine();
            Console.WriteLine($"Running for {seconds} seconds...");

            Console.WriteLine();
            Console.WriteLine("Not yet implemented - sorry!");
            return;
        }

        public static void PerfectNumbers(int seconds)
        {
            Console.WriteLine("Perfect Numbers:");
            Console.WriteLine("A number whose divisors add up to that number.");
            Console.WriteLine();
            Console.WriteLine($"Running for {seconds} seconds...");

            Console.WriteLine();
            Console.WriteLine("Not yet implemented - sorry!");
            return;
        }

        public static void CollatzConjecture(int seconds)
        {
            Console.WriteLine("Collatz Conjecture:");
            Console.WriteLine("The following sequence always reaches 1. Starting with any positive integer...");
            Console.WriteLine("     If the number is even, divide by 2.");
            Console.WriteLine("     If the number is odd, multiply by 3 and add 1.");
            Console.WriteLine();
            Console.WriteLine($"Running for {seconds} seconds...");

            Stopwatch timer = Stopwatch.StartNew();
            int initialValue = 1;
            int currentValue;

            do
            {
                initialValue += 1;

                currentValue = initialValue;
                Console.Write($"Initial value {currentValue}: ");

                while (currentValue != 1)
                {
                    Console.Write($"{currentValue}, ");

                    if (currentValue % 2 == 0)
                    {
                        currentValue /= 2;
                    }
                    else
                    {
                        currentValue = (currentValue * 3) + 1;
                    }
                }

                Console.WriteLine("1");
            }
            while (timer.Elapsed.Seconds < seconds);

            timer.Stop();
            Console.WriteLine($"{seconds} seconds elapsed! Completed {initialValue} iterations.");
            Console.Read();
        }
    }
}
