using System;

namespace DelegatesSample
{
    class Program
    {
        //private delegate void SortOp(Person[] p);
        static void Main(string[] args)
        {
            Person[] people =
            {
                new Person("Hans", "Meiser"),
                new Person("Bärbel", "Schäfer"),
                new Person("Andreas", "Türk"),
                new Person("Arrabella", "Kiesbauer")
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
