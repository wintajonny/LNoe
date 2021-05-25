

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people =
            {
            new Person("Jonas", "Stadler"),
            new Person("Bernhard", "Piendl"),
            new Driver("Thomas", "Winter"),
            new Driver("Christian", "Nagel")
            };

            foreach (Person person in people)
            {
                person.Drive();
            }
        }


    }
}
