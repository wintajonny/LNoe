using System;

namespace ArraySample
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = { new Person { FirstName = "Alex", LastName = "Hollmann" }, new Person { FirstName = "Christian", LastName = "Maslo" }, new Person { FirstName = "Mario", LastName = "P" }, new Person { FirstName = "Cvijeta", LastName = "K" }, new Person { FirstName = "Julia", LastName = "B" } };
            Console.WriteLine("Before sort:");
            foreach (var p in persons)
            {
                Console.WriteLine($"{p.FirstName} {p.LastName}");
            }
            Array.Sort(persons);
            Console.WriteLine("Now sorted:");
            foreach (var p in persons)
            {
                Console.WriteLine($"{p.FirstName} {p.LastName}");
            }
        }
    }
}
