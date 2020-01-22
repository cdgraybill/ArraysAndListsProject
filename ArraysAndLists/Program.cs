using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            /* Create two Lists of type int.
             * Name one List "evens" */
            var evens = new List<int>();

            /* Name the other List "odds" */
            var odds = new List<int>();

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            Console.WriteLine("Odds");
            for (int i = 1; i < 10; i += 2)
            {
                odds.Add(i);
            }

            foreach (var num1 in odds)
            {
                Console.WriteLine(num1);
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Evens");
            for (int i = 2; i < 11; i += 2)
            {
                evens.Add(i);
            }

            foreach (var num2 in evens)
            {
                Console.WriteLine(num2);
            }

            Console.WriteLine();
            Console.WriteLine("Press any key.");
            Console.ReadLine();
            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
        }
    }
}
