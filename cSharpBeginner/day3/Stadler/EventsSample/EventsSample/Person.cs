using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsSample
{
    public class Person
    {
        private readonly string _name;
        public Person(string name) => _name = name;

        public void NotifyOnCarCreated(object? sender, string car)
        {
            Console.WriteLine($"{_name}: the car {car} is now ready!");
        }
    }
}
