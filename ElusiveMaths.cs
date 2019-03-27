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
        public static List<int> primeNumbers;

        public static void GoldbachsConjecture(int seconds)
        {
            Stopwatch timer = Stopwatch.StartNew();

            int initialValue = 0;
            int limit = 0;
            int firstDivisor = 0;
            int secondDivisor = 0;

            do
            {
                initialValue += 2;

                limit = primeNumbers.Count;
                for (int i = 0; i < limit; i++)
                {
                    if (primeNumbers[i] > initialValue)
                    {
                        limit = (i - 1);
                        break;
                    }
                }

                for (int i = 0; i <= limit; i++)
                {
                    //for (int j = 0; j <= limit; j++)
                    for (int j = (limit - 1); j >= 0; j--)
                    {
                        if (primeNumbers[i] + primeNumbers[j] == initialValue)
                        {
                            firstDivisor = primeNumbers[i];
                            secondDivisor = primeNumbers[j];
                            break;
                        }
                    }
                }

                Console.WriteLine($"{initialValue} = {firstDivisor} + {secondDivisor}");
            }
            while ((timer.Elapsed.Minutes * 60) + timer.Elapsed.Seconds < seconds);

            Console.WriteLine($"\nFound {primeNumbers.Count} primes, and proved theorem for {initialValue / 2} iterations.");

            return;
        }

        public static void CalculatePrimes(int seconds)
        {
            Console.WriteLine($"Calculating prime numbers for {seconds} seconds first...\n");

            int runningValue = 0;
            int sumOfDivisors = 0;
            int lastPrime = 0;

            primeNumbers = new List<int>();

            Stopwatch timer = Stopwatch.StartNew();
            primeNumbers.Add(1);

            do
            {
                runningValue++;

                if (runningValue > 2 && (runningValue % 2 == 0))
                {
                    continue;
                }

                sumOfDivisors = 0;

                for (int i = 1; i <= runningValue; i++)
                {
                    if (runningValue % i == 0)
                    {
                        sumOfDivisors++;
                    }
                }

                if (sumOfDivisors == 2)
                {
                    primeNumbers.Add(runningValue);
                    lastPrime = runningValue;
                }
            } while ((timer.Elapsed.Minutes * 60) + timer.Elapsed.Seconds < seconds);

            timer.Stop();
        }

        public static void PerfectNumbers(int seconds)
        {
            Stopwatch timer = Stopwatch.StartNew();
            int initialValue = 1;
            int currentValue;
            int sumOfNumbers = 0;
            int currentTime = 0;

            List<int> perfectNumbersFound = new List<int>();

            do
            {
                initialValue += 1;
                sumOfNumbers = 0;
                currentValue = initialValue;

                for (int i = 1; i < currentValue; i++)
                {
                    if (currentValue % i == 0)
                    {
                        sumOfNumbers += i;
                    }
                }

                if (currentValue == sumOfNumbers)
                {
                    perfectNumbersFound.Add(currentValue);
                }
            }
            while ((timer.Elapsed.Minutes * 60) + timer.Elapsed.Seconds < seconds);

            timer.Stop();

            Console.Write($"Completed {initialValue} iterations.  Perfect numbers found: ");

            for (int i = 0; i < perfectNumbersFound.Count; i++)
            {
                if ((i + 1) == perfectNumbersFound.Count)
                {
                    Console.WriteLine($"{perfectNumbersFound[i]}.\n");
                }
                else
                {
                    Console.Write($"{perfectNumbersFound[i]}, ");
                }
            }
        }

        public static void CollatzConjecture(int seconds)
        {
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
            while ((timer.Elapsed.Minutes * 60) + timer.Elapsed.Seconds < seconds);

            timer.Stop();
            Console.WriteLine($"{seconds} seconds elapsed! Completed {initialValue} iterations.");
        }
    }
}
