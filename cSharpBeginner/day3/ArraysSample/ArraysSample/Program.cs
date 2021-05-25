using System;
using System.Collections;
using System.IO;

namespace ArraysSample
{
    class Program
    {
        static void Main(string[] args)
        {
            SpanSample();

            string[] names = { "James", "Niki", "Jochen", "Lewis" };

            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //IEnumerator enumerator = names.GetEnumerator();
            //while (enumerator.MoveNext())
            //{
            //    string name = (string)enumerator.Current;
            //    Console.WriteLine(name);
            //}

            var jNames = names.Filter(name => name.StartsWith("J"));

            foreach (var jname in jNames)
            {
                Console.WriteLine(jname);
            }

            HelloWorld hw = new();
            foreach (string s in hw)
            {
                Console.WriteLine(s);
            }
        }

        static void SpanSample()
        {
            int[] data = { 1, 2, 3, 4, 5, 6, 7, 8 };
            var span1 = data.AsSpan();

            span1[2] = 42;

            Console.WriteLine(data[2]);

            var span2 = span1.Slice(2, 2);
            span2.Fill(33);


            Index i1 = 3;
            Index i2 = ^2; // hat operator

            var d1 = data[i1];
            var d2 = data[i2];


            Range r1 = ..;
            Range r2 = 3..^2;

            var subset = data[3..^2];
            subset[0] = 11;

            var subset1 = span1[3..^2];
            subset1[0] = 11;

            foreach (var item in data[3..^2])
            {
                Console.WriteLine(item);
            }


        }
    }
}
