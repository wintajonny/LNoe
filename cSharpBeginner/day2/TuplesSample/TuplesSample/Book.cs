using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuplesSample
{
    class Book
    {
        public string? Title { get; set; }
        public string? Publisher { get; set; }

        //public void Deconstruct(out string? title, out string? publisher)
        //{
        //    title = Title;
        //    publisher = Publisher;
        //}
    }

    static class BookExtensions
    {
        public static void Deconstruct(this Book book, out string? title, out string? publisher)
        {
            title = book.Title;
            publisher = book.Publisher;
        }
    }
}
