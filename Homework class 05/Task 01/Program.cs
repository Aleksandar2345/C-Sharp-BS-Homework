using System;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Task 1
            //Make a method called AgeCalculator
            //The method will have one input parameter, your birthday date
            //The method should return your age
            //Show the age of a user after he inputs a date
            //Note: take into consideration if the birthday is today, after or before today

            Console.WriteLine("Task 01");

            Console.WriteLine("Enter a month: ");
            bool successOne = int.TryParse(Console.ReadLine(), out int month);
            Console.WriteLine("Enter a day: ");
            bool successTwo = int.TryParse(Console.ReadLine(), out int day);
            Console.WriteLine("Enter a year: ");
            bool sucessThree = int.TryParse(Console.ReadLine(), out int year);

            if (!sucessThree && !successTwo && !successOne)
            {
                Console.WriteLine("Please enter valid dates");
                return;
            }
            else
            {
                DateTime inputtedDate = new DateTime(year, month, day);
                Console.WriteLine(inputtedDate);
                CalculateAge(inputtedDate, DateTime.Now);
            }
            
            





            static void CalculateAge (DateTime birthday, DateTime current)
            {
                int months;
                int days;
                int years;

                if (current.Year < birthday.Year)
                {
                    Console.WriteLine("You have not been born yet");
                }
                else
                {
                    //int years = current.Year - birthday.Year;
                    
                    
                    if(current.Month >= birthday.Month)
                    {
                        months = current.Month - birthday.Month;
                        
                    }
                    else
                    {
                        months = 12 - (birthday.Month - current.Month);
                    }

                     if(current.Day >= birthday.Day)
                    {
                        days = current.Day - birthday.Day;
                    }
                    else
                    {
                        days = birthday.Day - current.Day;
                    }

                      if(current.Day > birthday.Day || current.Month > birthday.Month)
                    {
                        years = current.Year - birthday.Year - 1 ;
                    }
                    else
                    {
                        years = current.Year - birthday.Year;
                    }
                     
                    Console.WriteLine($"You are {years} years, {months} months and {days} days old! ");

                }
            }
        }
    }
}
