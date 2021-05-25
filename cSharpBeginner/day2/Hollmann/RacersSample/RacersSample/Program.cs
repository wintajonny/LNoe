using System;
using System.Collections.Generic;

namespace RacersSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var racers = new List<Racer>()
            {
             new Racer("Alexander", "Hollmann", 1, 0, "TheBeginners"),
            new Racer("Christian", "Maslo", 2, 1, "TheBeginners"),
            new Racer("Mario", "P", 3, 1, "TheBeginners"),
            new Racer("Erik", "Prachtl", 3, 0, ""),
            new Racer("Null", "Nuller", 0, 0, null)
            };

            foreach (var racer in racers)
            {
                Console.WriteLine(racer.ToString());
            }


        }
    }
}
