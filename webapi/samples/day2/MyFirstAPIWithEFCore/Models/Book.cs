using System.ComponentModel.DataAnnotations;

namespace MyFirstAPI.Models
{
    public record Book(
        [property: StringLength(50)]
        string Title, 
        string? Publisher, 
        int BookId);

}
