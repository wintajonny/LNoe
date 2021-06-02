using System;

namespace MyClassLib
{
    public class Demo
    {
        public void Foo(string s)
        {
            Console.WriteLine(s.ToUpper());
        }

        public string GetAString()
        {
            return "Foo";
        }

        public string? GetANullableString()
        {
            return null;
        }
    }
}
