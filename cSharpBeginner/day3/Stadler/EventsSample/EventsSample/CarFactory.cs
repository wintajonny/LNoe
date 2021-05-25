using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsSample
{
    public class CarFactory
    {
        public void CreateCar(string car)
        {
            Console.WriteLine($"{car} wurde produziert.");
            CarCreated?.Invoke(this, car);
        }
        public EventHandler<string>? CarCreated;
    }
}
