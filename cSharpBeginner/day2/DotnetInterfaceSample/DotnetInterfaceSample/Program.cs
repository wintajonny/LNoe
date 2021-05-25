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

            Array.Sort(racers, new PersonComparer(PersonCompareType.FirstName));

            foreach (var racer in racers)
            {
                Console.WriteLine($"{racer:F}");
            }

            StringCollection coll = new();
            coll.Add()
        }
    }
}
