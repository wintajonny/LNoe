using AsyncStreamsSample;
using System;
using System.Threading;
using System.Threading.Tasks;

Console.WriteLine("GPS Data:");

CancellationTokenSource cancellation = new(TimeSpan.FromSeconds(10));

Device device1 = new();


try
{
    await foreach (var data in device1.GetGpsPosition().WithCancellation(cancellation.Token))
    {
        Console.WriteLine($"Lat: {data.Lat}, Long: {data.Long}");
    }
}
catch (OperationCanceledException e)
{
    Console.WriteLine(e.Message);
}




