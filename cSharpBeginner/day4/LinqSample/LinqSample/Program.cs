using DataLib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqSample
{
    class Program
    {
        static void Main(string[] args)
        {
            GenerationSample();
            // IntoLinq();
            // DeferredQuery();
            // SimpleRacerMethodSyntax();
            // GroupingSample();
            // CompoundFromSample();
            // GroupingSampleWithMethods();
        }

        private static void GenerationSample()
        {
            var items = Enumerable.Range(1, 100000).Select(i => new Team($"team {i}"));
            foreach (var item in items)
            {
                Console.WriteLine(item.Name);
            }
        }

        private static void GroupingSampleWithMethods()
        {
            var q = Formula1.GetChampions()
                .GroupBy(r => r.Country)
                .Select(g => new { Group = g, Count = g.Count()})
                .OrderByDescending(g1 => g1.Count)
                .ThenBy(g1 => g1.Group.Key)
                .Select(g1 => new
                {
                    Country = g1.Group.Key,
                    Count = g1.Count
                }).Take(6);


            foreach (var country in q)
            {
                Console.WriteLine($"{country.Country} {country.Count}");
            }
        }

        private static void CompoundFromSample(string car)
        {
            var q = from r in Formula1.GetChampions()
                    from c in r.Cars
                    where c == car
                    orderby r.LastName
                    select r;

            foreach (var r in q)
            {
                Console.WriteLine(r);
            }
        }

        private static void CompoundFromSample()
        {
            //Func<string, IEnumerable<Racer>> racersByCar = car => 
            //    from r in Formula1.GetChampions()
            //        from c in r.Cars
            //        where c == car
            //        orderby r.LastName
            //        select r;

            static IEnumerable<Racer> RacersByCar(string car) =>
                from r in Formula1.GetChampions()
                from c in r.Cars
                where c == car
                orderby r.LastName
                select r;

            var q1 = RacersByCar("Tyrrell");
            var q2 = RacersByCar("Lotus");
            var q = q1.Union(q2);

            foreach (var r in q)
            {
                Console.WriteLine(r);
            }
        }

        private static void GroupingSample()
        {
            var q = (from r in Formula1.GetChampions()
                    group r by r.Country into g
                    let count = g.Count()
                    orderby count descending, g.Key
                    select new
                    {
                        Country = g.Key,
                        Count = count
                    }).Take(6);

            foreach (var country in q)
            {
                Console.WriteLine($"{country.Country} {country.Count}");
            }
        }

        private static void SimpleRacerQuery()
        {
            var q = from r in Formula1.GetChampions()
                    where r.Country == "Brazil"
                    orderby r.Wins descending
                    select new
                    {
                        Name = r.FirstName + " " + r.LastName,
                        Wins = r.Wins
                    };

            foreach (var item in q)
            {
                Console.WriteLine($"{item.Name} {item.Wins}");
            }
        }

        private static void SimpleRacerMethodSyntax()
        {
            var q = Formula1.GetChampions()
                .Where(r => r.Country == "Brazil")
                .OrderByDescending(r => r.Wins)
                .Select(r => new
                {
                    Name = r.FirstName + " " + r.LastName,
                    Wins = r.Wins
                });



            foreach (var item in q)
            {
                Console.WriteLine($"{item.Name} {item.Wins}");
            }
        }

        private static void DeferredQuery()
        {
            List<string> names = new() { "Niki", "Jochen", "James", "Lewis", "Juan" };

            var q = (from n in names
                    where n.StartsWith("J")
                    select n).ToList();

            ShowNames("first", q);

            names.Add("Jack");

            ShowNames("second", q);
        }

        private static void ShowNames(string title, IEnumerable<string> names)
        {
            Console.WriteLine(title);
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();
        }

        private static void IntoLinq()
        {
            string[] names = { "Niki", "Jochen", "James", "Lewis", "Juan" };

            var q = from n in names
                    where n.StartsWith("J")
                    select n;

            foreach (var name in q)
            {
                Console.WriteLine(name);
            }

        }

        private static void MethodSyntax()
        {
            string[] names = { "Niki", "Jochen", "James", "Lewis", "Juan" };

            var q = names.Where(n => n.StartsWith("J")).Select(n => n);

            foreach (var name in q)
            {
                Console.WriteLine(name);
            }

        }
    }
}
