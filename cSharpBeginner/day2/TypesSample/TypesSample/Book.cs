using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesSample
{
    public class Book
    {
        //public Book()
        //{

        //}

        private string? _title;  // field

        public string? Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
            }
        }

        private string? _publisher;
        public string? Publisher
        {
            get => _publisher;
            init => _publisher = value;
        }

        // auto property
        public string? Isbn { get; init; }

        //public void Show()
        //{
        //    Console.WriteLine($"Title: {_title}");
        //}

        public void Show() => 
            Console.WriteLine($"Title: {_title}");
    }
}
