using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacersSample
{
    class Racer
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Starts { get; set; }
        public int Wins { get; set; }
        public string? RacingTeam { get; set; }

        public Racer()
        {
                
        }

        public Racer(string firstName, string lastName, int starts, int wins, string? racingTeam)
        {
            FirstName = firstName;
            LastName = lastName;
            Starts = starts;
            Wins = wins;
            RacingTeam = racingTeam;
        }

        public override string ToString()
        {
            return $"Firstname: {FirstName}, Lastname: {LastName}, Starts: {Starts}, Wins: {Wins}, RacingTeam: {RacingTeam ?? ""}";
        }
    }
}
