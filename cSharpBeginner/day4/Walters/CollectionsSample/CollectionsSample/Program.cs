using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsSample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list1 = Enumerable.Range(1, 1000).Select(i => new RandomNumber().Rn).ToList();
            foreach(string item in list1){
                Console.WriteLine(item + " " + list1.Capacity);
            }
            Console.WriteLine();

            //beim hinzufügen eines weiteren items wird die Capacity auf 2000 verdoppelt
            list1.Add(new RandomNumber().Rn);
            Console.WriteLine(list1.Last() + " " + list1.Capacity);
        }
    }

    /// <summary>
    /// A Fixed length string containing a random number from 0 to 999999
    /// </summary>
    public class RandomNumber
    {
        Random rnd = new Random();
        private string rn;

        public string Rn
        {
            get { return rnd.Next(0,999999).ToString("D6"); }
        }

    }

}
