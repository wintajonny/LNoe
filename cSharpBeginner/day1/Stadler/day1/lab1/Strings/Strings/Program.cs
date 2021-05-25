using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string newString = Console.ReadLine();

            Console.WriteLine("erste Buchstabe:" + newString[..1]);
            Console.WriteLine("erste Buchstabe:" + newString[^4..^0]);
            Console.WriteLine("erste Buchstabe:" + newString[2..10]);
        }
    }
}
