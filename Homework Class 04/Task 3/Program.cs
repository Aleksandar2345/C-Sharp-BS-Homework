using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {

            //## Task 3
            //*Create a function that takes a number as input.This method should return the sum of the digits in the number.

            Console.WriteLine("Task 3 - Create a function that takes a number as input.This method should return the sum of the digits in the number.");
            Console.WriteLine("Please enter a number with more than one digit");
            
            bool sucess = int.TryParse(Console.ReadLine(), out int enteredNumber);
            
            
            if (!sucess)
            {
                Console.WriteLine("Please enter a number as an input");
            } 
            else
            {
                int sum = 0;
               while(enteredNumber != 0)
                {
                    sum += enteredNumber % 10;
                    enteredNumber /= 10;
                }
                Console.WriteLine($"The sum of the digits contained in the number is {sum}");
            }
            

        }
    }
}
