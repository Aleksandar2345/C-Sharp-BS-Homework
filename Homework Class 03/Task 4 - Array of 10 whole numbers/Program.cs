using System;

namespace Task_4___Array_of_10_whole_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //## Task 4
            //            *Make a new console application.
            //           * Create an array of 10 whole numbers(integers). 
            //*Find the minimum and maximum and print them in the console.

            Console.WriteLine("Taks 4 - Array of 10 whole numbers");
            int[] arrayOfWhole = { 45, 5, 15, 25, 20, 30, 50, 40, 10, 35 };

            Array.Sort(arrayOfWhole);
            Console.WriteLine($"The minimum value number is :{arrayOfWhole[0]}");
            Console.WriteLine($"The maximum value number is :{arrayOfWhole[arrayOfWhole.Length - 1]}");
        }
    }
}
