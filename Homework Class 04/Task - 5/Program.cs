using System;

namespace Task___5
{
    class Program
    {
        static void Main(string[] args)
        {
            //   ## Task 5
            //          * Create an array of integers. Get the number of elements and the values of the elements from input.
            //          * Find how many times there are two 3 next to each other.
            //   * Example: 
            //   * Enter number of elements: 7
            //   * Enter first element: 9
            //   * Enter second element: 3
            //   * Enter first element: 3
            //   * Enter first element: 4
            //   * Enter first element: 3
            //   * Enter first element: 3
            //   * Enter first element: 3
            //   * Three times there are threes next to each other.


            Console.WriteLine("Task 05");

            
            int numberOfElements;
            Console.WriteLine("Please enter the number of elements in the array");
            bool sucess = int.TryParse(Console.ReadLine(), out numberOfElements);

            if (!sucess)
            {
                Console.WriteLine("You have entered invalid input, please enter a number");
                return;
            }
            else
            {
                Console.WriteLine($"You have entered that the array will have {numberOfElements} elements");
                int[] arrayOfIntegers = new int[numberOfElements];

                Console.WriteLine($"Now please enter {numberOfElements} elements");
                bool secondSuccess = int.TryParse(Console.ReadLine(), out int number);

                if (!secondSuccess && numberOfElements != 0)
                {
                    Console.WriteLine($"You have entered invalid input or less than {numberOfElements}, please enter a number");
                    return;
                }
                else
                {
                    //for (i = 0; numberOfElements < arrayOfIntegers.Length; if++ )
                    int counter = 0;
                    while (numberOfElements >= counter)
                    {
                        if (numberOfElements > counter + 1)
                        {
                            arrayOfIntegers[counter] = number;
                            Console.WriteLine($"You have entered {number} as your {counter + 1} element");
                            number = int.Parse(Console.ReadLine());
                            counter++;

                        }
                        else
                        {
                            Console.WriteLine($"You have entered {number} as your {counter + 1} element");
                            Console.WriteLine("You have entered all the elements");
                            Console.WriteLine(CheckIfSame(arrayOfIntegers));
                            break;
                        }
                        
                    } 

                }


            }

            static int CheckIfSame(int [] array)
            {
                int[] newArray = new int[array.Length];
                array.CopyTo(newArray, 0);
                int i = 0;
                foreach (int item in array)
                {
                    if (item == 3)
                    {
                        if (array[item] == newArray[item])
                        {
                            i++;
                        }
                        else
                        {
                            continue;
                        }

                    }
                }                           
                
                Console.WriteLine($"The number three (3) was {i} times next to eachother");
                return i; // nemav zivci da mislam resenie i za ova :( bez nego nema siguren path 
                
            }
        }
    }
}
