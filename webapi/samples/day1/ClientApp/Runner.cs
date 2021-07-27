using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ClientApp
{
    class Runner
    {
        public async Task GetBooksAsync()
        {
            JsonSerializerOptions options = new()
            {
                PropertyNameCaseInsensitive = true
            };
            var client = new HttpClient();
            var response = await client.GetAsync("https://localhost:5001/api/Books");
            response.EnsureSuccessStatusCode();
            string json = await response.Content.ReadAsStringAsync();

            var books = JsonSerializer.Deserialize<IEnumerable<Book>>(json, options: options);
            if (books is null) return;

            foreach (var book in books)
            {
                Console.WriteLine(book.Title);
            }
        }
    }

    public record Book(string Title, string? Publisher, int BookId);
}
