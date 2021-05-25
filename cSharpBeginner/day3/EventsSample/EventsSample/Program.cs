using System;

namespace EventsSample
{
    class Program
    {
        static void Main(string[] args)
        {
            CarFactory factory = new();

            Person seb = new Person("Sebastian");
            factory.CarCreated += seb.ACarCreated;


            factory.CreateACar("Ferrari");

            Person lewis = new Person("Lewis");
            factory.CarCreated += lewis.ACarCreated;

            factory.CreateACar("Aston Martin");

            factory.CarCreated -= seb.ACarCreated;

            factory.CreateACar("Red Bull Racing");

        }


    }
}
