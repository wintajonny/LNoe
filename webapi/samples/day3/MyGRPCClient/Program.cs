using Grpc.Net.Client;

using MyGRPCService;

using System;
using System.Threading.Tasks;

namespace MyGRPCClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("client - wait for service");
            Console.ReadLine();

            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Greeter.GreeterClient(channel);
            var reply = await client.SayHelloAsync(new HelloRequest() { Name = "Katharina" });
            Console.WriteLine(reply.Message);
        }
    }
}
