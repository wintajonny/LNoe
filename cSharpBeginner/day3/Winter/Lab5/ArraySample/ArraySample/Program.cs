using System;

namespace ArraySample
{
    class Program
    {
        public delegate void SortDelegate(Person[] persons, PersonComparer comparer);

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

            SortDelegate sortDelegate = new(Array.Sort);
            sortDelegate(persons, new PersonComparer());

            //Array.Sort(persons, new PersonComparer());

            foreach (Person p in persons)
            {
                Console.WriteLine(p.FirstName + " " + p.LastName);
            }
        }
    }
}
