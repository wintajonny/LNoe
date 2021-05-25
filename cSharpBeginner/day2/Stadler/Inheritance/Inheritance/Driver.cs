using System;

namespace Inheritance
{
    public class Driver : Person
    {
        public Driver (string first , string last): base(first, last) { }
        public override void Drive()
        {
            Console.WriteLine($"{FirstName} {LastName} drives fast");
        }
    }

}
