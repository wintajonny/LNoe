using System;

namespace CarFactorySample
{
    class Program
    {
        static void Main(string[] args)
        {
            CarFactory cf = new("VW-Werk");
            Person horst = new("Horst");

            cf.CarCreated += horst.NotifyOnCarCreated;

            cf.CreateCar("Polo");
        }
    }
}
