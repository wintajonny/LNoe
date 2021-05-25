using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryEventSample
{
    class CarFactory
    {
        public delegate void CarInfo(string car);

        //private CarInfo? carCreated;
        //public event CarInfo CarCreated
        //{
        //    add => carCreated += value;
        //    remove => carCreated -= value;
        //}

        public event EventHandler<string>? CarCreated;

        public void CreateCar(string carName)
        {
            Console.WriteLine($"Created a new car: {carName}");
            CarCreated?.Invoke(this, carName);
        }

    }
}
