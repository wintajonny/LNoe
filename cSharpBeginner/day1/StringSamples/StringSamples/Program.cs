using System;

namespace StringSamples
{
    class Program
    {
        /// <summary>
        /// Adds two values
        /// </summary>
        /// <param name="x">The first value to add</param>
        /// <param name="y">The second value to add</param>
        /// <returns>A result</returns>
        static int Add(int x, int y)
        {
            return x + y;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
#if DEBUG
            Console.WriteLine("running in debug mode");
#else
            Console.WriteLine("not in debug mode");
#endif

#if NOAUTH
            Console.WriteLine("not using authentication");
#else
            Console.WriteLine("use auth");
#endif

            // one-line comment
            DateTime today = DateTime.Today;
            Console.WriteLine($"{today:D}");
            Console.WriteLine($"{today:d}");

            /*
             * multi-line comments
             * */

            int aNumber = 4211;
            Console.WriteLine($"{aNumber:e}");
            Console.WriteLine($"{aNumber:n}");
            Console.WriteLine($"{aNumber:x}");
            Console.WriteLine($"{aNumber:c}");

            string s1 = @$"abc\tde{aNumber}f";
            Console.WriteLine(s1);

            // indices and ranges
            string s = "The quick brown fox jumped over the lazy dogs down 1234567890 times";
            string the = s[..3];
            string quick = s[4..9];
            string times = s[^5..^0];
            Console.WriteLine(the);
            Console.WriteLine(quick);
            Console.WriteLine(times);
            Console.WriteLine();
        }
    }
}
