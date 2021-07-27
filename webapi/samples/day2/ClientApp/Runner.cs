using Microsoft.Extensions.Logging;

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ClientApp
{
    class Runner
    {
        //public Runner(IHttpClientFactory httpClientFactory)
        //{
        //    httpClientFactory.CreateClient("")
        //}

        private readonly HttpClient _httpClient;

        public Runner(HttpClient httpClient, ILogger<Runner> logger)
        {
            _httpClient = httpClient;
        }

        public async Task GetBooksAsync()
        {
            JsonSerializerOptions options = new()
            {
                PropertyNameCaseInsensitive = true
            };
            //using var client = new HttpClient();  // don't do this!
            var response = await _httpClient.GetAsync("/api/Books");
            response.EnsureSuccessStatusCode();
            //            string json = await response.Content.ReadAsStringAsync();  // use streams instead!
            var stream = await response.Content.ReadAsStreamAsync();
            var books = await JsonSerializer.DeserializeAsync<IEnumerable<Book>>(stream, options);

            // var books = JsonSerializer.Deserialize<IEnumerable<Book>>(json, options: options);
            if (books is null) return;

            foreach (var book in books)
            {
                Console.WriteLine(book.Title);
            }

        }
    }

    public record Book(string Title, string? Publisher, int BookId);
}
