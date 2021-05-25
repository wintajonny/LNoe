using DataLib;
using System;
using System.Linq;

namespace LINQSample
{
    class Program
    {
        static void Main(string[] args)
        {

            //Champions with Wins > 20
            Console.WriteLine("-------------------CHAMPS WITH MORE THAN 20 WINS-------------");
            var champsWith20Wins = Formula1.GetChampions()
                .Where(r => r.Wins > 20)
                .Select(r => r.FirstName + " " + r.LastName);


            foreach (var champs in champsWith20Wins)
            {
                Console.WriteLine($"{champs}");
            }

            //champions from italy
            Console.WriteLine("-------------------CHAMPS FROM ITALY-------------");
            var champsFromItaly = from r in Formula1.GetChampions()
                    where r.Country == "Italy"
                    orderby r.LastName
                    select r;

            foreach (var r in champsFromItaly)
            {
                Console.WriteLine(r);
            }


            //champions complete number of wins in brazil
            Console.WriteLine("-------------------TOTAL NUMBER OF WINS IN BRAZIL-------------");
            var champsNumberInBrazil = Formula1.GetChampions()
            .Where(c => c.Country == "Brazil")
            .Sum(a => a.Wins);





           Console.WriteLine(champsNumberInBrazil);


            //racer with the same name as the team
            Console.WriteLine("-------------------Racer with the same name as team-------------");
            var racersWithSameNameAsTeam = Formula1.GetChampions()
            .Where(c => Formula1.GetConstructorChampions().Where(cc => cc.Name != "" && cc.Name == c.LastName).FirstOrDefault()?.Name == c.LastName);

            foreach (var r in racersWithSameNameAsTeam)
            {
                Console.WriteLine(r);
            }
        }
    }
}
