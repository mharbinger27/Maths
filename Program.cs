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
            Console.WriteLine("    a. Goldbach's Conjecture");
            Console.WriteLine("    b. Perfect Numbers");
            Console.WriteLine("    c. Collatz Conjecture");
            Console.WriteLine();
            Console.Write("Your selection: ");
            char userSelection = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.WriteLine($"Selected {userSelection}.  How many seconds?");
            Console.WriteLine();
            Console.Write("Your time: ");
            int userSeconds = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"Running {userSelection} for {userSeconds} seconds...");
            Console.WriteLine();

            string programToRun = userSelection.ToString();
            int secondsToRun = userSeconds;

            if (programToRun == "a")
            {
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

            return;
        }
    }
}
