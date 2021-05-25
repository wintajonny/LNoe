using DataLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace LinqSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("All Champions");
            QueryChampions();
            Console.WriteLine();

            Console.WriteLine("Champions with more than 20 Wins");
            QueryChampionsWithMoreThan20Wins();
            Console.WriteLine();

            Console.WriteLine("Champions from Italy");
            QueryChampionsFromItaly();
            Console.WriteLine();

            Console.WriteLine("Championship Wins By Racers From Brazil");
            QueryChampionshipWinsByRacersFromBrazil();
            Console.WriteLine();

            Console.WriteLine("Champions Where Team = Driver");
            QueryChampionsWithSameNameAsTeam();
            Console.WriteLine();

            Expression<Func<List<Racer>, List<Racer>>> expression = r => r.Where(n => n.Cars.Contains(n.LastName)).ToList();

            foreach (Racer r in expression.Compile()(Formula1.GetChampions().ToList()))
            {
                Console.WriteLine(r.ToString());
            }
        }

        static void QueryChampions()
        {
            List<Racer> q = Formula1.GetChampions().Where(n => n.Wins > 0).ToList();

            foreach(Racer r in q)
            {
                Console.WriteLine(r.ToString());
            }
        }

        static void QueryChampionsWithMoreThan20Wins()
        {
            var q = Formula1.GetChampions().Where(n => n.Wins > 20);
            foreach(Racer r in q)
            {
                Console.WriteLine(r.ToString());
            }
        }

        static void QueryChampionsFromItaly()
        {
            var q = Formula1.GetChampions().Where(n => n.Country == "Italy");
            foreach (Racer r in q)
            {
                Console.WriteLine(r.ToString());
            }
        }

        static void QueryChampionshipWinsByRacersFromBrazil()
        {
            var q = Formula1.GetChampions().Where(n => n.Country == "Brazil").Sum(n => n.Wins);

            Console.WriteLine(q);
        }

        static void QueryChampionsWithSameNameAsTeam()
        {
            var q = Formula1.GetChampions().Where(n => n.Cars.Contains(n.LastName));
            foreach (Racer r in q)
            {
                Console.WriteLine(r.ToString());
            }
        }
    }
}
