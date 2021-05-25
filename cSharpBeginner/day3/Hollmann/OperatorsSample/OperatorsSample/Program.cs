using System;

namespace OperatorsSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person() { FirstName = "Alex", LastName = "Hollmann" };
            var person2 = new Person() { FirstName = "Alex", LastName = "Hollmann" };
            var person3 = new Person() { FirstName = "Alex", LastName = "Hollmannnnnn" };

            if (person1.Equals(person1, person2))
            {
                Console.WriteLine("The same person!");
            }
            else
            {
                Console.WriteLine("Not the same person");
            }

            if (person1 == person2)
            {
                Console.WriteLine("The same person!");
            }
            else
            {
                Console.WriteLine("Not the same person");
            }

            if (person2 != person3)
            {
                Console.WriteLine("Not the same person (using != operator)!");
            }
            else
            {
                Console.WriteLine("The same person");
            }

            if (ReferenceEquals(person1,person2))
            {
                Console.WriteLine("The same person-OBJECT!");
            }
            else
            {
                Console.WriteLine("Not the same person-OBJECT");
            }


        }
    }
}
