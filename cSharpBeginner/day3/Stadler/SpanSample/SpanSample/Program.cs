using System;

namespace SpanSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Span<int> sp = arr.AsSpan();

            Span<int> sp2 = sp[^5..^0];
            sp2[1] = 200;

            sp[1..3].Fill(4);
            sp[8] = 100;

            foreach(int i in arr)
                Console.WriteLine( i);

            foreach(int i in sp)
                Console.WriteLine(i);
            Console.WriteLine();

            foreach(int i in sp2)
                Console.WriteLine(i);
        }
    }
}
