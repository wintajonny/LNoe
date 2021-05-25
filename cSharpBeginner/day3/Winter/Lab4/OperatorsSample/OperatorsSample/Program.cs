using System;

namespace OperatorsSample
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new("Thomas", "Winter");
            Person p2 = new("Thomas", "Winter");
            Person p3 = new("Christian", "Nagl");

            Console.WriteLine("Equals with the same person");
            if (p1.Equals(p2))
            {
                Console.WriteLine("Person 1 equals person 2 ");
            } else
            {
                Console.WriteLine("Person 1 does not equal person 2");
            }

            Console.WriteLine("\nEquals with different persons");
            if (p1.Equals(p3))
            {
                Console.WriteLine("Person 1 equals person 3 ");
            }
            else
            {
                Console.WriteLine("Person 1 does not equal person 3");
            }




            Console.WriteLine("\n\n== Operator with the same persons");
            if(p1 == p2)
            {
                Console.WriteLine("Person 1 equals person 2 ");
            }
            else
            {
                Console.WriteLine("Person 1 does not equal person 2");
            }

            Console.WriteLine("\n\n== Operator with different persons");
            if (p1 == p3)
            {
                Console.WriteLine("Person 1 equals person 3 ");
            }
            else
            {
                Console.WriteLine("Person 1 does not equal person 3");
            }

            Console.WriteLine("\n\n!= Operator with the same persons");
            if (p1 != p2)
            {
                Console.WriteLine("Person 1 does not equal person 2");

            }
            else
            {
                Console.WriteLine("Person 1 equals person 2 ");
            }
            Console.WriteLine("\n\n!= Operator with the same persons");
            if (p1 != p3)
            {
                Console.WriteLine("Person 1 does not equal person 3");
            }
            else
            {
                Console.WriteLine("Person 1 equals person 3 ");
            }

        }
    }
}
