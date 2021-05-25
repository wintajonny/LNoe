using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryEventSample
{
    class Person
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void CarForPersonCreated(object? sender, string car)
        {
            Console.WriteLine($"{FirstName} {LastName}: A {car} has been created for you!");
        }
    }
}
