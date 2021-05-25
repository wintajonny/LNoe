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
        public event EventHandler<string>? CarCreated;

        public void CreateACar(string car)
        {
            Console.WriteLine($"Car {car} was created! Fresh from the factory!");
            CarCreated?.Invoke(this, car);
        }
    }
}
