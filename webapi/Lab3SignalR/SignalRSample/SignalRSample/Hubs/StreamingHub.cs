using Microsoft.AspNetCore.SignalR;
using SignalRSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace SignalRSample.Hubs
{
    public class StreamingHub : Hub
    {
        public async IAsyncEnumerable<MyData> RequestStream(int iterations, [EnumeratorCancellation] CancellationToken cancellationToken = default)
        {
            for(int i = 0; i < iterations; i++)
            {
                cancellationToken.ThrowIfCancellationRequested();

                yield return new MyData { Text = $"text {i}", Number = i };
                await Task.Delay(300, cancellationToken);
            }
        }
    }
}
