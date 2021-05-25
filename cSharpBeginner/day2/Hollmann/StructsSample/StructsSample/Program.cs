using System;

namespace StructsSample
{
    public struct Foo
    {
        public int bar;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Foo test = new Foo();
            test.bar = 100;
            Console.WriteLine(test.bar);
            ChangeWithoutReference(test);
            Console.WriteLine(test.bar);
            Console.WriteLine("The value did not change..");
            ChangeWithReference(ref test);
            Console.WriteLine(test.bar);
            Console.WriteLine("The value did change since we delivered a reference..");

        }

        static void ChangeWithoutReference(Foo a)
        {
            a.bar++;
        }
        static void ChangeWithReference(ref Foo a)
        {
            a.bar++;
        }
    }
}
