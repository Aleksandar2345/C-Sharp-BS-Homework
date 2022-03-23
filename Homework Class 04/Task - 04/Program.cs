using System;

namespace Task___04
{
    class Program
    {
        static void Main(string[] args)
        {
            //## Task 4
            //* Create four methods for calculation sum, substract, multiplication and division of two numbers.
            //* Create a function called calculator, that has three parameters.The first one is operator and then two numbers.
            //* Depending on the value of the operator, call the corresponding function from the four ones from above.

            Console.WriteLine("Task 04");


            Console.WriteLine("Please enter an arithmetic operator from the following: +, -, *, /");
            bool success = char.TryParse(Console.ReadLine(), out char calculationSign);
            Console.WriteLine("Please enter your first number");
            bool successSecond = int.TryParse(Console.ReadLine(), out int firstNumber);
            Console.WriteLine("Please enter your second number");
            bool successThird = int.TryParse(Console.ReadLine(), out int secondNumber);
            

            if (!success && !successSecond && !successThird)
            {
                Console.WriteLine("Please enter a valid arithmetic operator and valid numbers");
            }
            else
            {
                Console.WriteLine($" The operation {calculationSign} between the numbers {firstNumber} and {secondNumber} is equal to = {Calculator(calculationSign, firstNumber, secondNumber)}");
            }
            
            

            static int  Calculator (char arithemticOperator,int num1,int num2)
            {
                if(arithemticOperator == '+')
                {
                    return Sum(num1, num2);
                }
                if (arithemticOperator == '-')
                {
                    return Substract(num1, num2);
                }
                if (arithemticOperator == '*')
                {
                    return Multiply(num1, num2);
                }
                if (arithemticOperator == '/')
                {
                    return Division(num1, num2);
                }
                else
                {
                    throw new Exception("The entered values are not valid");
                }
            }
            
            
                       
            
            static int Sum(int num1,int num2)
            {
                return num1 + num2;
            } 
            static int Substract(int num1,int num2)
            {
                return num1 - num2;
            }
            static int Multiply(int num1,int num2)
            {
                return num1 * num2;
            }  
            static int Division(int num1,int num2)
            {
                return num1 / num2;
            }

        }
    }
}
