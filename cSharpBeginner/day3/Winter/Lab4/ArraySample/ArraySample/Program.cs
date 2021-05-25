using System;

namespace ArraySample
{
    class Program
    {
        static void Main(string[] args)
        {

            Person[] persons = new Person[]
            {
                new Person("Thomas","Winter"),
                new Person("Bernhard","Piendl"),
                new Person("Jonas","Stadler"),
                new Person("Christian","Nagel"),
            };

            foreach(Person p in persons)
            {
                Console.WriteLine(p.FirstName + " " + p.LastName);
            }

            Array.Sort(persons, new PersonComparer());

            foreach (Person p in persons)
            {
                Console.WriteLine(p.FirstName + " " + p.LastName);
            }
        }
    }
}
