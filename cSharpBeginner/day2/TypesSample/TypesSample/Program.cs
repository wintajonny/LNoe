using System;

namespace TypesSample
{
    

    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new("Tom", "Turbo");

            // Person p2 = new();

            Book b1 = new();
            b1.Title = "Professional C#";  // set accessor
            string title = b1.Title;  // get accessor
            b1.Show();

            Book b2 = new() // use object initializer
            {
                Title = "a title",
                Publisher = "a publisher",
                Isbn = "343487"
            };

            // b2.Isbn = "4838934";  init-only set accessor property

            AnyParameterNumber(1, 2, 3, 4, 8, 12, 22);
            AnyParameterNumber();


        }

        static void AnyParameterNumber(params int[] data)
        {
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }
    }
}
