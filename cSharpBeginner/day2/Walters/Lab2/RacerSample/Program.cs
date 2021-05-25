using System;

namespace RacerSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Racer racer = new("Michael", "Schuhmacher", "Ferrari", 10, 9);
            racer.ConsoleWrite();
            Racer racer2 = new("Bernd", "Müller",null, 100, 0);
            racer2.ConsoleWrite();
        }
    }
}
