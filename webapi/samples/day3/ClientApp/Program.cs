using Microsoft.AspNetCore.SignalR.Client;

using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace ClientApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("client - wait for service");
            Console.ReadLine();
            CancellationTokenSource cts = new(10000);

            var hubConnection = new HubConnectionBuilder()
                 .WithUrl("https://localhost:5001/stream")
                 .Build();

            try
            {
                await hubConnection.StartAsync();
                var stream = hubConnection.StreamAsync<SomeData>("RequestStream", 30);
                await foreach (var item in stream.WithCancellation(cts.Token))
                {
                    Console.WriteLine($"{item.Number} {item.Text}");
                }
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("canceled!");
            }
        }
    }

    public class SomeData
    {
        public string Text { get; set; }
        public int Number { get; set; }
    }
}
