using System;

namespace CarFactoryEventSample
{
    class Program
    {
        static void Main(string[] args)
        {
            CarFactory factory = new();

            factory.CarCreated += CarCreatedEventCw;


            Person p1 = new("Thomas", "Winter");
            Person p2 = new("Christian", "Nagel");

            factory.CarCreated += p1.CarForPersonCreated;
            factory.CreateCar("Ferrari");
            factory.CarCreated += p2.CarForPersonCreated;
            factory.CreateCar("Mazda");
            factory.CarCreated -= p1.CarForPersonCreated;
            factory.CreateCar("Hyundai");
        }

        private static void CarCreatedEventCw(object? sender, string carName)   //parameters have to be the same as in CarInfo
        {
            Console.WriteLine("Hooray, the event has been fired for " + carName );
        }
    }
}
