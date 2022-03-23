using System;

namespace Task_1___Last_five_characters
{
    class Program
    {
        static void Main(string[] args)
        {
            //## Task 1
            //*Take one string from the input and print its last 5 characters.


                       Console.WriteLine("Task 1 - Take one string from the input and print its last 5 characters.");
            Console.WriteLine("Please enter some text longer than 5 characters");
            string enteredText = Console.ReadLine();
            if (enteredText.Length <= 5)
            {
                Console.WriteLine("Your text is not longer than 5 characters");
            }
            else
            {
                string substring = enteredText.Substring((enteredText.Length - 5), 5);
                Console.WriteLine($"The last 5 characters from the input are {substring}");
            }
        }
    }
}
