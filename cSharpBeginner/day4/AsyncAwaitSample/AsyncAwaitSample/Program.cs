using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwaitSample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await RunnerAsync();
            Console.WriteLine("Main Completed");
            ShowTaskInformation("main completed");

           
            Console.ReadLine();
        }

        private static Task RunnerAsync()
        {

            ShowTaskInformation("runner started");
            // string result = await GreetAsync("Stephanie", 3000);
            GreetAsync("Katharina", 3000).ContinueWith(t1 =>
            {
                ShowTaskInformation("runner completed");
            });

        }


        static void ShowTaskInformation(string title)
        {
            Console.WriteLine(title);
            Console.WriteLine($"Thread: {Thread.CurrentThread.ManagedThreadId}, Task: {Task.CurrentId}");
            Console.WriteLine();
        }

        static Task<string> GreetAsync(string name, int ms)
        {
            return Task<string>.Run(() =>
            {
                string result = Greet(name, ms);
                ShowTaskInformation("in GreetAsync");
                return result;
            });
        }

        static string Greet(string name, int ms)
        {
            Thread.Sleep(ms);
            return $"Hello, {name}";
        }
    }
}
