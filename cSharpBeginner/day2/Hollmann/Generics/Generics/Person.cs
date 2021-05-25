using System;

namespace Generics
{
    public class Person : IDisplayAble
    {
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString() => $"{FirstName} {LastName}";

        public void Display()
        {
            Console.WriteLine(this);
        }
    }
}