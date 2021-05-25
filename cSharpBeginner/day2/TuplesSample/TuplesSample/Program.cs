using System;

namespace TuplesSample
{
    class Program
    {
        static void Main(string[] args)
        {
            (string s, int i) = ("magic", 42);
            var t1 = ("magic", 42);  // create a tuple

            (int res, int rem) = Divide(5, 3);  // deconstruction to res and rem variables

            var t2 = Divide(7, 3);  // returns a tuple
            Console.WriteLine($"result: {t2.Result}, remainder: {t2.Remainder}");

            (int res1, _) = Divide(7, 4); // discard the remainder


            var b1 = new Book { Title = "Professional C#", Publisher = "Wiley" };
            (string? title, _) = b1;  // calls Deconstruct

        }

        static (int Result, int Remainder) Divide(int x, int y)
        {
            int result = x / y;
            int rem = x % y;
            return (result, rem);
        }
    }
}
