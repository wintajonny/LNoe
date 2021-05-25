using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable enable

namespace RacersSample
{
    class Racer 
    {
        public Racer (string firstName, string lastName, int starts, int wins, string? racingTeam)
        {
            FirstName = firstName;
            LastName = lastName;
            Starts = starts;
            Wins = wins;
            RacingTeam = racingTeam;
        }

        public Racer(string firstName, string lastName, int starts, int wins) : this(firstName, lastName, starts, wins, null)
        {
        }

        public string FirstName { get; set; }
        string LastName { get; set; }
        int Starts { get; set; }
        int Wins { get; set; }
        string? RacingTeam { get; set; }
        int Lose { get; set; }

        public override string? ToString()
        {
            return $"firstName {FirstName}, lastName {LastName},starts {Starts}, wins {Wins}, racingTeam{RacingTeam} ";
        }

    }

}
