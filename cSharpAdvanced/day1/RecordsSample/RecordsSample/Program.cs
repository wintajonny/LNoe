using System;

namespace RecordsSample
{
    record InnerRecord(string Something);
    record Book(string Title, string? Publisher = default)
    {
        public string[] Chapters { get; init; }
        public InnerRecord Inner { get; init; }

        //public override string ToString()
        //{
        //    return Title;
        //}
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new("Professional C#") { Chapters = new string[] { "one", "two" }, Inner = new InnerRecord("my something") };
            Book b2 = new("Professional C#") { Chapters = new string[] { "one", "two" } };
            Console.WriteLine(b1.ToString());

            if (!object.ReferenceEquals(b1, b2))
            {
                Console.WriteLine("b1 and b2 are not the same reference");
            }


            if (b1.Equals(b2))
            {
                Console.WriteLine("b1 and b2 are the same");
            }
            else
            {
                Console.WriteLine("b1 and b2 are not the same");
            }
        }
    }
}
