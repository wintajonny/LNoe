using System;
using System.Linq;

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

            //IComparable Approach
            Array.Sort(people);

            foreach(Person person in people)
            {
                Console.WriteLine(person);
            }

            //IComparer Approach
            //PersonComparer pc = new PersonComparer();
            //people.Sort(pc);

            Console.WriteLine();

            //Linq Approach
            var sortedPeople = people.OrderBy(n => n.LastName);
            foreach(Person person in sortedPeople)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
