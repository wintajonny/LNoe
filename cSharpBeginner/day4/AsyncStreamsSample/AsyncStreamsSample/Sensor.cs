using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncStreamsSample
{
    public record MyData(int Val1, int Val2);

    public class Sensor
    {
        public async IAsyncEnumerable<MyData> GetSensorData([EnumeratorCancellation] CancellationToken token = default)
        {
            Random r = new();

            while (true)
            {
                await Task.Delay(1000, token);
                // token.ThrowIfCancellationRequested()
                yield return new MyData(r.Next(20), r.Next(20));
            }
        }
    }
}
