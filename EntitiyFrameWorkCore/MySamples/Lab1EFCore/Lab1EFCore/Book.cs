using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1EFCore
{
    class Book
    {
        public Book(string title, string publisher, int id = 0)
        {
            Title = title;
            Publisher = publisher;
            Id = id;
        }

        [MaxLength(100)]
        public string Title { get; set; }
        public string Publisher { get; set; }
        public int Id { get; set; }

    }
}
