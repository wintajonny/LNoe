using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

using WebAPISample;

namespace ClientApp
{
    public class Runner
    {
        private readonly HttpClient _httpClient;
        public Runner(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task ShowBooksAsync()
        {
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            //var resp = await _httpClient.GetAsync("/api/Books");
            //resp.EnsureSuccessStatusCode();
            //var stream = await resp.Content.ReadAsStreamAsync();
            //var books = await JsonSerializer.DeserializeAsync<IEnumerable<Book>>(stream, options);

            var books = await _httpClient.GetFromJsonAsync<IEnumerable<Book>>("/api/Books");

            //string json = await resp.Content.ReadAsStringAsync();
            //var books = JsonSerializer.Deserialize<IEnumerable<Book>>(json, new JsonSerializerOptions
            //{
            //    PropertyNameCaseInsensitive = true
            //});
            foreach (var book in books)
            {
                Console.WriteLine(book.Title);
            }
        }
    }
}
