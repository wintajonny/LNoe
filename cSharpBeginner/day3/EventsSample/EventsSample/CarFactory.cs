using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsSample
{
    public delegate void CarInfo(string car);

    public class CarFactory
    {
        //private CarInfo? _carCreated;
        //public event CarInfo CarCreated
        //{
        //    add => _carCreated += value;
        //    remove => _carCreated -= value;
        //}

        // public event CarInfo? CarCreated;
        public event EventHandler<string>? CarCreated;

        public void CreateACar(string car)
        {
            Console.WriteLine($"Create car {car}");

            // _carCreated?.Invoke(car);
            // CarCreated?.Invoke(car);
            CarCreated?.Invoke(this, car);
        }
    }
}
