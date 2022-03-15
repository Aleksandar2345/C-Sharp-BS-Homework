using System;

namespace Task3___Dont_print_out_numbers_divisible_by_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //## Task 3
            //Ask the user to enter a number as an input.Print all the numbers except the numbers divisible by 5.When you come to 80, the limit is reached.

            Console.WriteLine("Task 3 - Print all numbers expect the numbers divisible by 5");

            Console.WriteLine("Please enter a number");
            bool success = int.TryParse(Console.ReadLine(), out int enteredNumber);
            if (!success)
            {
                Console.WriteLine("Please enter a numeric value");
            }
            else
            {
                Console.WriteLine($"You have entered the number {enteredNumber}");
            }

            for (int i = 0; i <= enteredNumber; i++)
            {
                if (i % 5 != 0 && i <= 80)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
