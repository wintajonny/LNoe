using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1WebApi.Models
{
    public class Books
    {
        public record Book(string Title, string? Publisher, int BookId);
    }
}
