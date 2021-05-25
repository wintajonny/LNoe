

namespace RecordsSample
{
   // public record Book(string Title, string Publisher, int Isbn);
   public record Book
    {
        public Book(string title, string publisher, int isbn)
        {
            Title = title;
            Publisher = publisher;
            Isbn = isbn;
        }

        public string Title { get; set; }
        public string Publisher { get; set; }
        public int Isbn { get; set; }
    public void Deconstruct(out string title, out string publisher, out int isbn)
        {
            title = Title;
            publisher = Publisher;
            isbn = Isbn;
        }
    }

}
