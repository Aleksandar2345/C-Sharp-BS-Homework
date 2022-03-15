using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {

            double firstNumber = 8;
            double secondNumber = 4;


            double findStatistics = 0;

            switch (findStatistics)
            {
                case 1:
                    if ((firstNumber % 2 == 0 || firstNumber == 0) && (secondNumber % 2 == 0 || secondNumber == 0))
                    {
                        findStatistics = firstNumber + secondNumber;
                        Console.WriteLine("Both numbers are even");
                        Console.WriteLine($"The operation and result are {firstNumber} + {secondNumber} = {findStatistics} ");
                    }
                    break;
                case 2:
                    if ((firstNumber % 2 != 0 || firstNumber != 0) && (secondNumber % 2 == 0 || secondNumber == 0))
                    {
                        findStatistics = firstNumber - secondNumber;
                        Console.WriteLine(findStatistics);
                    }
                    break;
                case 3:
                    if ((firstNumber % 2 == 0 || firstNumber == 0) && (secondNumber % 2 != 0 || secondNumber != 0))
                    {
                        findStatistics = firstNumber - secondNumber;
                        Console.WriteLine(findStatistics);
                    }
                    break;
                case 4:
                    if ((firstNumber % 2 != 0 || firstNumber != 0) && (secondNumber % 2 != 0 || secondNumber != 0))
                    {
                        findStatistics = firstNumber * secondNumber;
                        Console.WriteLine(findStatistics);
                    }
                    break;
                default:
                    findStatistics = 0;
                    break;

            }





        }
    }
}
