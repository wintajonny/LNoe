﻿using System;
#nullable enable

namespace RacersSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Racer racer1 = new("Thomas", "Winter", 10, 1, "Ferrari");
            Racer racer2 = new("Bernhard", "Piendl", 10, 3, "Mercedes");
            Racer racer3 = new("Jonas", "Stadler", 10, 0);

            Console.WriteLine(racer1.ToString());
            Console.WriteLine(racer2.ToString());
            Console.WriteLine(racer3.ToString());
        }

    }
}