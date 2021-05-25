using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncSample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await RunnerAsync("Alexander");
            await RunnerAsync("Christian");

            Console.WriteLine("Main Completed");
            Console.ReadLine();
        }
        private static Task RunnerAsync(string name)
        {
            return GreetAsync(name, 300);
        }
        static Task<string> GreetAsync(string name, int ms)
        {
            return Task<string>.Run(() =>
            {
                string result = Greet(name, ms);
                return result;
            });
        }
        static string Greet(string name, int ms)
        {
            Thread.Sleep(ms);
            Console.WriteLine($"Hello, {name}");
            return $"Hello, {name}";
        }
    }
}
