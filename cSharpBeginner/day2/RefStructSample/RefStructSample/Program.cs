using System;

namespace RefStructSample
{
    // struct Demo  // pass by value
    class Demo
    {
        public int A;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Demo d1 = new();
            d1.A = 1;
            ChangeDemo(ref d1);
            Console.WriteLine(d1.A);  // 1 or 2 or 3
        }

        static void ChangeDemo(ref Demo d)
        {
            d.A = 2;
            d = new();
            d.A = 3;
        }
    }
}
