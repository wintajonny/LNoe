using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsSample
{
    public class ExampleClass : IDisplayAble
    {
        public ExampleClass(int exampleInt, string exampleString)
        {
            ExampleInt = exampleInt;
            ExampleString = exampleString;
        }
        public override string ToString() => $"{this.ExampleInt}, {this.ExampleString}";

        public int ExampleInt { get; set; }
        public string ExampleString { get; set; }

        public void Display()
        {
            Console.WriteLine(this);
        }
    }
}
