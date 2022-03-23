using System;

namespace SumOfEven
{
    class Program
    {
        static void Main(string[] args)
        {
            //## Task 2
            //            Make a console application called SumOfEven. Inside it create an array of 6 integers.Find and print the sum of the even numbers from the array:
            //*Test Data:
            //            *Enter integer no.1:
            //    *4
            //  * Enter integer no.1:
            //    *3
            //  * Enter integer no.1:
            //    *7
            //  * Enter integer no.1:
            //    *3
            //  * Enter integer no.1:
            //    *2
            //  * Enter integer no.1:
            //    *8
            //* Expected Output:
            //            *The result is: 14

            Console.WriteLine("Task 2 - Sum of even");
            int[] arrayOfInt = { 1, 2, 3, 4, 5, 6 };
            int sumOfEven = 0;
            foreach (int item in arrayOfInt)
            {
                if (item % 2 == 0)
                {
                    sumOfEven += item;
                }
            }
            Console.WriteLine($"The result is: {sumOfEven}");

        }
    }
}
