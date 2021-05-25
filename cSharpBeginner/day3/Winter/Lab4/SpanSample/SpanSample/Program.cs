using System;

namespace SpanSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integerArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Span<int> integerSpan = integerArray.AsSpan();

            Console.WriteLine("Unchanged Array");
            foreach (int i in integerArray)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Unchanged Span");
            foreach (int i in integerSpan)
            {
                Console.WriteLine(i);
            }

            integerSpan.Fill(3);
            integerSpan[0..3].Fill(0);
            integerSpan[^3..^0].Fill(5);

            Console.WriteLine("\n\nChanged Array");
            foreach (int i in integerArray)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Changed Span");
            foreach (int i in integerSpan)
            {
                Console.WriteLine(i);
            }

        }
    }
}
