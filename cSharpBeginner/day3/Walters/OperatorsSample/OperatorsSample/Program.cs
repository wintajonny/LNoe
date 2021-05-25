using System;

namespace OperatorsSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new("Albert", "Einstein");
            Person p2 = new("Hans", "Meiser");
            Person p3 = new("Albert", "Einstein");

            Console.WriteLine(p1.Equals(p3));
            Console.WriteLine(p1 == p2);
        }
    }
}
