using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //## Task 2
            //*Take a sentence as input and find its words.


            Console.WriteLine("Task 2 - Take a sentence as input and fint its words");
            Console.WriteLine("Please enter a sentence");
            string enteredSentence = Console.ReadLine();
            if (!enteredSentence.Contains(" "))
            {
                Console.WriteLine("Please enter a sentence, not a single word.");
            }
            else
            {
                string[] splitByWords = enteredSentence.Split(" ");
                int index = 0;
                foreach (string word in splitByWords)
                {

                    Console.WriteLine($"The {index + 1} word: {word} ");
                    index++;
                }
                
            }

        }
    }
}
