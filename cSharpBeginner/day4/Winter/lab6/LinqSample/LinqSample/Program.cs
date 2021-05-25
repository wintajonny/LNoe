using DataLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace LinqSample
{
    class Program
    {



        static void Main(string[] args)
        {
            //ReadAllChampions();
            //ReadAllChampionsMethodSyntax();
            //ReadAllChampionsWithWinsGreater20();
            //ReadAllChampionsWhereCountryEqualsItaly();
            //GetAllWinsFromBrazil();
            //GetAllWinsFromCountry("Austria");
            //GetRacersWhereLastnameEqualsTeamname();


            Expression<Func<IList<Racer>, IEnumerable<Racer>>> expression = list => (from r1 in list
                                                                                     where r1.Country == "Austria" && r1.Wins > 6
                                                                                     select r1);
            var result = expression.Compile()(Formula1.GetChampions());
            writeRacers(result);
        }

        private static void writeRacers(IEnumerable racers)
        {
            foreach (var r in racers)
            {
                Console.WriteLine(r.ToString());
            }
        }

        private static void ReadAllChampions()
        {
            var queryResult = from r in Formula1.GetChampions()
                              select r;

            writeRacers(queryResult);
        }

        private static void ReadAllChampionsMethodSyntax()
        {
            var queryResult = Formula1.GetChampions().Select(r => r);

            writeRacers(queryResult);
        }

        private static void ReadAllChampionsWithWinsGreater20()
        {
            var queryResult = from r in Formula1.GetChampions()
                              where r.Wins >= 20
                              select r;

            writeRacers(queryResult);
        }

        private static void ReadAllChampionsWhereCountryEqualsItaly()
        {
            var queryResult = from r in Formula1.GetChampions()
                              where r.Country.Equals("Italy")      //where r.Country == "Italy"
                              select r;

            writeRacers(queryResult);
        }

        private static void GetAllWinsFromBrazil()
        {
            var queryResult = (from r in Formula1.GetChampions()
                               where r.Country == "Brazil"
                               select r.Wins).Sum();

            Console.WriteLine($"Number of Wins from Brazil: {queryResult}");
        }

        private static void GetAllWinsFromCountry(string country)
        {
            var queryResult = (from r in Formula1.GetChampions()
                               where r.Country == country
                               select r.Wins).Sum();
            
            Console.WriteLine($"Number of Wins from {country}: {queryResult}");

        }

        private static void GetRacersWhereLastnameEqualsTeamname()
        {
            var queryResult = from r in Formula1.GetChampions()
                              from t in r.Cars
                              where r.LastName == t
                              select r;

            writeRacers(queryResult);
        }

        
    }
}
