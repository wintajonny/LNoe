using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceSample
{
    public class Racer : Person
    {
        public Racer(string first, string last) : base(first, last)
        {
        }

        public override void Drive()
        {
            Console.WriteLine($"{FirstName} {LastName} drives fast");
        }
    }
}
