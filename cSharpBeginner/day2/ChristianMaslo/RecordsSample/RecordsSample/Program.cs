using System;

namespace RecordsSample
{
    record book(string Title, string Publisher, string ISBN);
    class Program
    {
        static void Main(string[] args)
        {
            book book1 = new book("The House", "Kephen Sting", "3456");
            book book2 = new book("The House", "Kate Hell", "3456");

            if (book1 == book2)
            {
                Console.WriteLine("The books are the same!");
            }
            else
            {
                Console.WriteLine("The books are NOT the same!");
            }
            if (book1.Equals(book2))
            {
                Console.WriteLine("This is the same book!");
            }
            else
            {
                Console.WriteLine("This is not the same book!");
            }

            if (book1.Title == book2.Title)
            {
                Console.WriteLine("These books have the same title!");
            }

            var book3 = book2 with { Publisher = "Kephen Sting" };
            Console.WriteLine(book3.ToString());

            var book4 = book3 with { };
            Console.WriteLine(book4);
            if (!ReferenceEquals(book3, book4)) Console.WriteLine("The reference does not equal, as book4 is a clone of book3");
            if (book4 == book3) Console.WriteLine("Values are equal!");

            (string title, string publisher, _) = book1;

            Console.WriteLine($"Title '{title}' from {publisher}.");
        }
    }
}
