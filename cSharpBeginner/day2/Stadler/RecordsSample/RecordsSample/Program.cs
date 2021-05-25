using System;

namespace RecordsSample
{
    class Program
    {
        static void Main(string[] args)
        {
           Book book = new("New Book", "Jonas Stadler ", 1234);
            
            Book book1 = book with { Title = "Old Book" };
            if (book == book1)
            {
                Console.WriteLine("Is equal");
            }
            else
            {
                Console.WriteLine("Is not equal");
            }
            Console.WriteLine(new object());
            Console.WriteLine(book);
            (string Title, _, _) = book;
            book.Title = "12";
            Console.WriteLine(book);
        }
    }
}
