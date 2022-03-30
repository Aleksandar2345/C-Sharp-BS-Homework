using GetPersonStats.Models;
using System;

namespace GetPersonStats
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 2
            //Create a class Human
            //Add properties: FirstName, LastName, Age
            //Create a method called GetPersonStats that returns the full name of the human as well as their age
            //Create an object human by asking the user to fill the required information(take first name, last name and age from user input)
            //Call the GetPersonStats method and print the result in the console after the object is created

            Console.WriteLine("Task 02");

            Human humanFromInput = new Human();
            
            Console.WriteLine("Please enter your first name");
            humanFromInput.FirstName = Console.ReadLine();            
            Console.WriteLine("Please enter your last name");
            humanFromInput.LastName = Console.ReadLine();
            Console.WriteLine("Please enter your age");
            bool success = int.TryParse(Console.ReadLine(), out int humanAge);

            if (!success)
            {
                Console.WriteLine("Please enter a numeric value for your age");
            }
            else
            {
                humanFromInput.Age = humanAge;
            }


            Console.WriteLine(GetPersonStatsFunction(humanFromInput.FirstName, humanFromInput.LastName, humanFromInput.Age));






            string GetPersonStatsFunction(string firstName, string lastName, int age)
            {
                if (firstName == null || lastName == null || age == 0)
                {
                    return null;
                }
                else
                {
                    //Console.WriteLine($"The entered human name is {FirstName}, his last name is {LastName}, and he is {Age} years old ");
                    return ($"The entered human name is {firstName}, his last name is {lastName}, and he is {age} years old ");
                }
            }








            }

        
    }
}
