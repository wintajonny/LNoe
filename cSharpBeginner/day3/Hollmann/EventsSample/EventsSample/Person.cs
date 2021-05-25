using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsSample
{
    class Person
    {
        private readonly string _firstName;
        private readonly string _lastName;

        public Person(string FirstName, string LastName)
        {
            _firstName = FirstName;
            _lastName = LastName;
        }

        public void CarWasCreated(object? sender, string car)
        {
            Console.WriteLine($"{_firstName} {_lastName} notices that a new {car} is available!");
        }
    }
}
