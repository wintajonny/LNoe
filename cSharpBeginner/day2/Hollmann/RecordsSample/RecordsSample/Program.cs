using System;

namespace RecordsSample
{
    record Book(string Title, string Publisher, string Isbn);



    class Program
    {
        static void Main(string[] args)
        {
            Book aBook = new Book("The Time Traveler's Wife", "MacAdam/Cage", "12345a");
            Book bBook = new Book("The Time Traveler's Wife", "RandomHouse", "12322a");

            if (aBook == bBook)
            {
                Console.WriteLine("This is the same book!");
            }
            else
            {
                Console.WriteLine("This is not the same book!");
            }

            if (aBook.Equals(bBook))
            {
                Console.WriteLine("This is the same book!");
            }
            else
            {
                Console.WriteLine("This is not the same book!");
            }

            if (aBook.Title == bBook.Title)
            {
                Console.WriteLine("These books have the same title!");
            }
     

            var cBook = bBook with { Publisher = "AlexanderHollmann" }; 
            Console.WriteLine(cBook.ToString());

            var dBook = cBook with { };

            if (!ReferenceEquals(bBook, cBook)) Console.WriteLine("DBook is a clone of CBook! Therefore the references don't equal");
            if (dBook == cBook) Console.WriteLine("But the values are equal!");

            //deconstruction
            (string title, string? publisher, _) = cBook; 

            Console.WriteLine($"Title: {title}, Publisher: {publisher}");
        }
    }
}
