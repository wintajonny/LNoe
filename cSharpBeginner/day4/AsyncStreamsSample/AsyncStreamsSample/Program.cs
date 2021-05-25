using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncStreamsSample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            CancellationTokenSource cts = new(8000);

            try
            {
                Sensor sensor = new();
                await foreach (var (val1, val2) in sensor.GetSensorData().WithCancellation(cts.Token))
                {
                    Console.WriteLine($"{val1} {val2}");
                }
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("cancelled");
            }

            Console.ReadLine();
        }
    }
}
