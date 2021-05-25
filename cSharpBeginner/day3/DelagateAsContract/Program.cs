using System;
using System.Collections.Specialized;

namespace DotnetInterfaceSample
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = { "Gerhard", "Ayrton", "Niki", "Graham", "Lewis" };
            Array.Sort(data);
            foreach (var d in data)
            {
                Console.WriteLine(d);
            }

            Person[] racers = new[]
            {
                new Person("Gerhard", "Berger"),
                new Person("Ayrton", "Senna"),
                new Person("Niki", "Lauda"),
                new Person("Graham", "Hill"),
                new Person("Lewis", "Hamilton")
            };

            // Array.Sort(racers);

            //Array.Sort(racers, new PersonComparer(PersonCompareType.FirstName));


            // Array.Sort(racers, ComparePersons);

            // Array.Sort(racers, (Person p1, Person p2) => p1.LastName.CompareTo(p2.LastName));
            Array.Sort(racers, (p1, p2) => p1.LastName.CompareTo(p2.LastName));

            foreach (var racer in racers)
            {
                Console.WriteLine($"{racer:F}");
            }
        }

        static int ComparePersons(Person p1, Person p2)
        {
            return p1.FirstName.CompareTo(p2.FirstName);
        }
    }
}
