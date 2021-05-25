using System;
using System.Linq;

namespace SpanSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = Enumerable.Range(1, 30).ToArray();
            var span1 = data.AsSpan();

            Console.WriteLine(data[2]);

            span1[5] = 333;

            Console.WriteLine(data[2]);
            Console.WriteLine(span1[5]);

            // the value did not change
            Console.WriteLine("Changes don't occur in the source - just in the new span");
            
        }
    }
}
