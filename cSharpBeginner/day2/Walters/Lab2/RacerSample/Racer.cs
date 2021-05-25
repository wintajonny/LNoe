using System;
using System.Collections.Generic;
using System.Text;

namespace RacerSample
{
    public class Racer
    {
        public Racer(string firstName, string lastName, string? racingTeam, int starts, int wins)
        {
            FirstName = firstName;
            LastName = lastName;
            RacingTeam = racingTeam ?? "kein Team";
            Starts = starts;
            Wins = wins;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? RacingTeam { get; set; }
        public int Starts { get; set; }
        public int Wins { get; set; }

        public void ConsoleWrite()
        {
            Console.WriteLine($"Der Name des Fahrers ist {FirstName} {LastName}.");
            Console.WriteLine($"Er fährt für {RacingTeam}.");
            Console.WriteLine($"Von {Starts} Rennen hat er {Wins} gewonnen.");
        }
    }
}
