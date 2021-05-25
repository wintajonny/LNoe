using System;

namespace GenericsSample
{
    class Program
    {
        static void Main(string[] args)
        {
            MyGenericCollection<ExampleClass> coll3 = new MyGenericCollection<ExampleClass>();
            coll3.Add(new ExampleClass(23, "Jonas Stadler"));
            coll3.Add(new ExampleClass(30, "Bernhard Piendl"));
        }
    }
}
