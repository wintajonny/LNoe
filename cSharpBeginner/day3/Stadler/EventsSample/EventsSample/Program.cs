using System;

namespace EventsSample
{
    class Program
    {
        static void Main(string[] args)
        {
            CarFactory cf = new();
            Person horst = new("Horst");

            cf.CarCreated += horst.NotifyOnCarCreated;

            cf.CreateCar("Polo");
            cf.CreateCar("Hyundai");
        }
    }
}
