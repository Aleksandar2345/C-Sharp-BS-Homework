using System;


namespace GetPersonStats.Models
{
    public class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Human()
        {

        }

        public Human(string firstName, string lastName, int age)
        {
            if (String.IsNullOrEmpty(firstName))
            {
                throw new Exception("First name must not be empty!");
            }
            if (String.IsNullOrEmpty(lastName))
            {
                throw new Exception("Last name must not be empty!");
            }
            if (age == 0)
            {
                throw new Exception("Age must not be 0!");
            }


            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
        
    }
        
}
