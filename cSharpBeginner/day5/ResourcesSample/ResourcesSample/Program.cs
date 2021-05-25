using System;
using System.Threading.Tasks;

namespace ResourcesSample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // GenerationsSample();

            // await WeakReferences();
            MyResource? r1 = new MyResource();

            try
            {
                r1.Foo();

            }
            finally
            {
                r1.Dispose();
            }

            // using statement
            using (MyResource r2 = new())
            {
                r2.Foo();
            }

            // using declaration
            using MyResource r3 = new();
            r3.Foo();
            // r3 out of scope (end of method?) - Dispose
        }

        private static async Task WeakReferences()
        {
            Sample? s1 = new();

            WeakReference wrs1 = new(s1);

            s1 = null;

            GC.Collect();
            GC.Collect();
            GC.Collect();

            await Task.Delay(500);
            GC.Collect();

            if (wrs1.IsAlive)  // race condition!!!
            {
                Sample? s3 = (Sample?)wrs1.Target;
            }

            Sample? s2 = (Sample?)wrs1.Target;
            if (s2 != null)
            {
                // a strong reference again

            }

            GC.Collect();
        }

        private static void GenerationsSample()
        {
            Sample s1 = new();
            int gen = GC.GetGeneration(s1);
            Console.WriteLine(gen);
            GC.Collect();
            gen = GC.GetGeneration(s1);
            Console.WriteLine(gen);

            GC.Collect();
            gen = GC.GetGeneration(s1);
            Console.WriteLine(gen);

            GC.Collect();
            gen = GC.GetGeneration(s1);
            Console.WriteLine(gen);

            GC.Collect();
            gen = GC.GetGeneration(s1);
            Console.WriteLine(gen);

            GC.Collect();
            gen = GC.GetGeneration(s1);
            Console.WriteLine(gen);
        }
    }

    class Sample
    {
        public int Data { get; set; }
    }
}
