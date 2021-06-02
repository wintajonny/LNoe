using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSamples
{
    public class Book
    {
        public Book(string title, int bookId = default)
        {
            Title = title;
            BookId = bookId;
        }
        public int BookId { get; set; }
        public string Title { get; set; }
        public string? Publisher { get; set; }
    }
}
