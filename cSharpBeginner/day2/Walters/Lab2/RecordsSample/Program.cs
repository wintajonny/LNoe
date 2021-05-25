using System;

namespace RecordsSample
{

    class Program
    {
        public record Book(string Title, string? Publisher, int Isbn);
        
        static void Main(string[] args)
        {
            var book1 = new Book("Alles über Pilze", "Fliegenpilzverlag", 123456);
            var book2 = new Book("Bäume", "Axel Springer", 223344);
            
            //Neuauflage des Pilzebuchs
            var book3 = book1 with { Isbn = 123457 };

            //Compare Books
            if (!book1.Equals(book3))
            {
                //Deconstruct book1
                (string Title, _, int Isbn) = book1;
                Console.WriteLine($"'{Title}' ist ein anderes Buch als '{book3.Title}'");
                
            }
            else
            {
                Console.WriteLine("Beide Bücher sind gleich.");
            }

        }
    }
}
