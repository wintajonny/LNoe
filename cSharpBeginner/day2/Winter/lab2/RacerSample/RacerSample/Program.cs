using System;

namespace RacerSample
{
    class Program
    {
        static void Main(string[] args)
        {

            Racer racer1 = new("Thomas", "Winter", 10, 8, "Ferrari");
            Racer racer2 = new("Bernhard", "Piendl", 10, 1);
            Racer racer3 = new("Jonas", "Stadler", 10, 1);


            Console.WriteLine("Some Racers: ");
            Console.WriteLine(racer1.ToString());
            Console.WriteLine(racer2.ToString());
            Console.WriteLine(racer3.ToString());
        }
    }
}
