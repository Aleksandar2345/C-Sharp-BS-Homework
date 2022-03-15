using System;

namespace FindStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
//            Create new console application “FindStatistics”. Input 2 numbers. If the two of them are even, print their sum,
//            if one of them is odd, print their difference, if the two off them are odd, multiply them. Don't print just the result,
//            but also the whole operation.Treat zero as even.
//            Please find example below:
//            * Test Data:
//            * Input the First Number: 8
//            * Input the Second Number: 5

//            * Expected Output:
//            * One of the numbers is odd.The operation and result are 8 - 5 = 3.


            Console.WriteLine("Task 1 - Find Statistics");
            Console.WriteLine("Please enter a number");
            double firstNumber;
            bool success = double.TryParse(Console.ReadLine(), out firstNumber);
            if (!success)
            {
                Console.WriteLine("Please enter a valid number");
            }
            else
            {
                Console.WriteLine($"You have entered number {firstNumber} as your first number");
                Console.WriteLine("Please enter a number");
            }

            double secondNumber;
            bool successSecond = double.TryParse(Console.ReadLine(), out secondNumber);
            if (!successSecond)
            {
                Console.WriteLine("Please enter a valid number");
            }
            else
            {
               
                Console.WriteLine($"You have entered number {secondNumber} as your second number");
            }
            

            double findStatistics = 0;
            if (success && successSecond)
            {
                    
                if ((firstNumber % 2 == 0 || firstNumber == 0) && (secondNumber % 2 == 0 || secondNumber == 0))
                {
                    findStatistics = firstNumber + secondNumber;
                    Console.WriteLine("Both numbers are even");
                    Console.WriteLine($"The operation and result are {firstNumber} + {secondNumber} = {findStatistics} ");
                }
              
                    
                else if ((firstNumber % 2 != 0 || firstNumber != 0) && (secondNumber % 2 == 0 || secondNumber == 0))
                {
                    findStatistics = firstNumber - secondNumber;
                    Console.WriteLine("One of the number is odd");
                    Console.WriteLine($"The operation and result are {firstNumber} - {secondNumber} = {findStatistics} ");
                }
                
                    
                else if ((firstNumber % 2 == 0 || firstNumber == 0) && (secondNumber % 2 != 0 || secondNumber != 0))
                {
                    findStatistics = firstNumber - secondNumber;
                    Console.WriteLine("One of the number is odd");
                    Console.WriteLine($"The operation and result are {firstNumber} - {secondNumber} = {findStatistics} ");
                }
             
                    
                else if ((firstNumber % 2 != 0 || firstNumber != 0) && (secondNumber % 2 != 0 || secondNumber != 0))
                {
                    findStatistics = firstNumber * secondNumber;
                    Console.WriteLine("Both numbers are odd");
                    Console.WriteLine($"The operation and result are {firstNumber} * {secondNumber} = {findStatistics} ");
                }
            }
        }
    }
}
