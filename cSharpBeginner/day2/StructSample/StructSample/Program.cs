using System;

namespace StructSample
{
    record MyRecord  // compiler creates a class (C# 9)
    {

    }

    // C# 10 only
    //struct record MyRecord2
    //    {
    //    }

    // class record MyRecord3
    // {
    // }

    // ref struct MyData  // stack only, kein boxing!
    struct MyData // stack oder heap
    {
        public int A;
    }

    class MyClass // heap
    {
        public int A;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Foo();

        }

        static void Foo()
        {
            MyData d1 = new();  // stack
            d1.A = 1;
            object o1 = d1; // make ref type from value type --> "boxing"

            MyData d2 = (MyData)o1;  // unboxing
        }

        static void Bar()
        {
            MyClass c = new(); // heap
            c.A = 1;
        }
    }
}
