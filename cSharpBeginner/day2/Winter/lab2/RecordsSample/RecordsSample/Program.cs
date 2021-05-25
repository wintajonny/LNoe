using System;

namespace RecordsSample
{
    class Program
    {

        public record Book (string Title, string Publisher, int Isbn);

        public record Person
        {
            public Person(string firstName, string lastName)
            {
                FirstName = firstName;
                LastName = lastName;
            }

            public string FirstName { get; set; }
            public string LastName { get; set; }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Book book1 = new("C# for dummies", "WinterReadGmBH", 123123);
            Book book2 = new("C# for dummies", "WinterReadGmBH", 123123);

            if (book1.Equals(book2))
            {
                //Book book1 = new("C# for dummies", "WinterReadGmBH", 123123);
                //Book book2 = new("C# for dummies", "WinterReadGmBH", 123123);
                Console.WriteLine("The Books are the same");
            } 
            else
            {
                //Book book1 = new("C# for dummies", "WinterReadGmBH", 123123);
                //Book book2 = new("C# for advanced", "WinterReadingGmBH", 123124);
                Console.WriteLine("The Books are not the same");
            }

            Book book3 = book1 with { Publisher = "WintaReadAG", Title = "How to deal with C# dummies" };
            Console.WriteLine(book3.ToString());

            (string title, string publisher, int isbn) = book3;
            Console.WriteLine($"Title: {title}, Publisher: {publisher}, ISBN: {isbn}");

            Person person1 = new("Thomas", "Winter");
            Console.WriteLine(person1.ToString());

        }
    }
}
