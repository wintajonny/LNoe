using System;

namespace GenericsSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //string und int sind nicht IDisplayAble!
            //MyGenericCollection<int> coll1 = new MyGenericCollection<int>();
            //coll1.Add(111);
            //coll1.Add(223);

            //MyGenericCollection<string> coll2 = new MyGenericCollection<string>();
            //coll2.Add("Auenland");
            //coll2.Add("Gondor");
            //coll2.Add("Isengard");

            //ExampleClass erbt IDisplayAble und kann daher in MyGenericCollection verwendet werden
            MyGenericCollection<ExampleClass> coll3 = new MyGenericCollection<ExampleClass>();
            coll3.Add(new ExampleClass(55,"Ralf Richter"));
            coll3.Add(new ExampleClass(60,"Dieter Bär"));
        }
    }
}
