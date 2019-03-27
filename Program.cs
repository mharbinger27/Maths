using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maths
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Elusive Maths!  Please select an option...");
            Console.WriteLine("    a. Goldbach's Conjecture: \n        Any even number larger than 2 can be written as the sum of two prime numbers.");
            Console.WriteLine("    b. Perfect Numbers: \n        A number whose divisors add up to that number.");
            Console.WriteLine("    c. Collatz Conjecture: ");
            Console.WriteLine("        The following sequence always reaches 1. Starting with any positive integer...");
            Console.WriteLine("        If the number is even, divide by 2...");
            Console.WriteLine("        If the number is odd, multiply by 3 and add 1.");
            Console.WriteLine();
            Console.Write("Your selection: ");
            char userSelection = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.Write($"Seconds to run: ");
            int userSeconds = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Running program '{userSelection}' for {userSeconds} seconds...\n");

            string programToRun = userSelection.ToString();
            int secondsToRun = userSeconds;

            if (programToRun == "a")
            {
                if (secondsToRun > 60)
                {
                    ElusiveMaths.CalculatePrimes(20);
                }
                else if (secondsToRun < 3)
                {
                    ElusiveMaths.CalculatePrimes(secondsToRun);
                }
                else
                {
                    ElusiveMaths.CalculatePrimes(secondsToRun / 3);
                }

                ElusiveMaths.GoldbachsConjecture(secondsToRun);
            }
            else if (programToRun == "b")
            {
                ElusiveMaths.PerfectNumbers(secondsToRun);
            }
            else if (programToRun == "c")
            {
                ElusiveMaths.CollatzConjecture(secondsToRun);
            }
            else
            {
                Console.WriteLine($"Whoops, turns out {programToRun} is not a valid choice...");
            }

            Console.Write("Press any key to exit: ");
            Console.ReadKey();

            return;
        }
    }
}
