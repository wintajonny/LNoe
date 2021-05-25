using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncStreamsSample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            CancellationTokenSource cts = new(15000);

            try
            {
                Sensor sensor = new();
                await foreach (string val1 in sensor.GetSensorData().WithCancellation(cts.Token))
                {
                    Console.WriteLine($"{val1}");
                }
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Loading Done!");
            }

            Console.ReadLine();
        }
    }
}
