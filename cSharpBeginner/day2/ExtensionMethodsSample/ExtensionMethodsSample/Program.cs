using System;

namespace ExtensionMethodsSample
{
    static class StringExtensions
    {
        public static void Foo(this string s)
        {
            Console.WriteLine($"Foo {s}");
        }

        public static int GetWordCount(this string s) => s.Split().Length;
    }

    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "test";
            s1.Foo();

            StringExtensions.Foo(s1);

            string s2 = "this is a string";
            int words = s2.GetWordCount();
            Console.WriteLine($"words: {words}");

        }
    }
}
