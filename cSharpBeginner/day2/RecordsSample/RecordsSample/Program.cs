using System;

namespace RecordsSample
{
    // nominal record
    //public record Book
    //{
    //    public Book(string title)
    //    {
    //        Title = title;
    //    }
    //    public string Title { get; set; }
    //}

    // positional record
    public record Book(string Title, string? Publisher = default, string? Isbn = default);
    //{
    //    public int ChapterCount { get; set; }
    //}

    public class Test1
    {
        public string? Title { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var b1 = new Book("Professional C#", "Wrox Press", "348849");
            string title = b1.Title;
            Console.WriteLine(b1.ToString());

            var b2 = b1 with { Publisher = "Wiley" };  // with expressions - create copy(clone), change properties in copy with object initializer
            Console.WriteLine(b2.ToString());

            (string t, string? pub, _) = b1;  // Deconstruct


            Test1 t1 = new() { Title = "one" };
            Test1 t2 = new() { Title = "one" };
            if (t1 == t2)
            {
                Console.WriteLine("the same");
            }
            else
            {
                Console.WriteLine("not the same");
            }

            Book bone = new("one");
            Book btwo = new("one");

            if (!object.ReferenceEquals(bone, btwo))
            {
                Console.WriteLine("not the same Book objects");
            }
            if (bone == btwo)
            {
                Console.WriteLine("the same Book");
            }
            else
            {
                Console.WriteLine("not the same Book");
            }
        }
    }
}
