using System;
using System.Collections.Generic;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Racer r1 = new();
            //r1.FirstName = "Lewis Hamilton";  // set accessor
            //string firstName = r1.FirstName;  // get accessor
            //b1.Show();

            var racers = new List<Racer>()
            {
                new Racer("Lewis", "Hamilton", 10, 8, "Mercedes"),
                new Racer("Sebastian", "Vettel", 10, 0, "Ferrari"),
                new Racer("Fernando", "Alonso", 10, 0, "Ferrari"),
                new Racer("Valteri", "Bottas", 10, 2, "Mercedes")

            };

            foreach (var racer in racers)
            {
                Console.WriteLine(racer.ToString());
            }
        }
    }
}
