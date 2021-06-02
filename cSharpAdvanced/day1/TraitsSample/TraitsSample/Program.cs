using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace TraitsSample
{
    public interface IEnumerableEx<T> : IEnumerable<T>
    {
        public IEnumerable<T> Filter(Func<T, bool> pred)
        {
            foreach (T item in this)
            {
                if (pred(item))
                {
                    yield return item;
                }
            }
        }
    }

    public class MyCollection<T> : Collection<T>, IEnumerableEx<T>
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            MyCollection<string> data = new() { "James", "Jochen", "Niki", "Gerhard", "Juan" };
            Sample(data);
            //var jNames = data.Where(s => s.StartsWith("J"));
            //foreach (var name in jNames)
            //{
            //    Console.WriteLine(name);
            //}

        }

        static void Sample(IEnumerableEx<string> names)
        {
            var jNames = names.Filter(n => n.StartsWith("J"));
            foreach (string name in jNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
