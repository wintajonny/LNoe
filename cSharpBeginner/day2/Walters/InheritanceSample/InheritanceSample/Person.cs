using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceSample
{
    public class Person
    {
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }


        public string FirstName { get; set; }
        public string LastName{ get; set; }

        public virtual void Drive()
        {
            Console.WriteLine($"{FirstName} {LastName} drives slow");
        }
    }

}
