using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsSample
{
    class Person
    {
        private readonly string _name;
        public Person(string name) => _name = name;


        //public void ACarCreated(string car)
        //{
        //    Console.WriteLine($"{_name}: the car {car} is available");
        //}
        public void ACarCreated(object? sender, string car)
        {
            Console.WriteLine($"{_name}: the car {car} is available");
        }
    }
}
