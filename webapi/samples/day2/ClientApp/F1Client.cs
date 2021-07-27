using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp
{
    class F1Client
    {
        private readonly HttpClient _httpClient;
        public F1Client(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task ShowRacersAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync("/downloads/Racers.xml");
                var xml = await response.Content.ReadAsStringAsync();
                Console.WriteLine(xml);
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
