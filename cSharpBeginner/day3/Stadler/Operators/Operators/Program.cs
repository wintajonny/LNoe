using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new("Jonas", "Stadler");
            Person person2 = new("Thomas", "Winter");
            Person person3 = new("Jonas", "Stadler");

            Console.WriteLine(person1.Equals(person3));
            Console.WriteLine(person1 == person2 );
        }
    }
}
