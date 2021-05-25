using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactorySample
{
    public class CarFactory
    {

        public string? Name { get; set; }

        public CarFactory(string? name)
        {
            Name = name;
        }
        public void CreateCar(string car)
        {
            Console.WriteLine($"{car} wurde in der Fabrik {Name} produziert.");
            CarCreated?.Invoke(this, car);

        }
        public EventHandler<string>? CarCreated;

    }
}
