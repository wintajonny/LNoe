using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstAPI.Models
{
    public record Book(string Title, string? Publisher, int BookId);

}
