using System;

namespace EventsSample
{
    class Program
    {
        static void Main(string[] args)
        {
            CarFactory factory = new();

            Person person1 = new Person("Alexander","Hollmann");

            factory.CarCreated += person1.CarWasCreated;
            factory.CreateACar("Kia Ceed");

            factory.CarCreated -= person1.CarWasCreated;
            Person person2 = new Person("Julia","B");
            factory.CarCreated += person2.CarWasCreated;

            factory.CreateACar("5er Golf");

            Person person3 = new Person("Cvijeta", "K");
            factory.CarCreated += person3.CarWasCreated;

            factory.CreateACar("3er BMW");

        }


    }
}
