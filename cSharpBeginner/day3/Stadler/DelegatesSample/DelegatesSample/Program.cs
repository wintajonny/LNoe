using System;

namespace DelegatesSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people =
            {
                new Person("Jonas", "Stadler"),
                new Person("Christian", "Nagel"),
                new Person("Thomas", "Winter"),
                new Person("Bernhard", "Piendl")
            };

            Action<Person[]> sort1 = Array.Sort;
            sort1(people);

            foreach(Person p in people)
            {
                Console.WriteLine(p.ToString());
            }
        }
    }
}
