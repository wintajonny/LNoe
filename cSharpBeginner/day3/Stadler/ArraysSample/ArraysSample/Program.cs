using System;

namespace ArraysSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people =
            {
                new Person("Hans", "Meiser"),
                new Person("Andreas", "Türk"),
                new Person("Arrabella", "Kiesbauer"),
                new Person("Bärbel", "Schäfer")
            };
            Array.Sort(people);
            foreach(Person person in people)
            {
                Console.WriteLine(person);
            }
        }
    }
}
