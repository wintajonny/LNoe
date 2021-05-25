using System;

namespace RangesAndIndices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter any String");
            string input = Console.ReadLine();
            
            if(input != null)
            {
                Console.WriteLine($"Die ersten 3 Zeichen sind '{input[0..3]}'");
                Console.WriteLine($"Die letzten 3 Zeichen sind '{input[^3..^0]}'");
            }
        }
    }
}
