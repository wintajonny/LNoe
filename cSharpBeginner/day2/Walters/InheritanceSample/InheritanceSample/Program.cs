using System;

namespace InheritanceSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people =
            {
                new Person("Arrabella", "Kiesbauer"),
                new Person("Hans", "Meiser"),
                new Racer("Andreas", "Türk"),
                new Racer("Bärbel", "Schäfer")
            };

            foreach(Person person in people)
            {
                person.Drive();
            }
        }
    }
}
