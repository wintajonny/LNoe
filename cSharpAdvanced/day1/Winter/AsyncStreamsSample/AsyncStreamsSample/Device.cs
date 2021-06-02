using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncStreamsSample
{

    public record GpsData (double Lat, double Long);

    class Device
    {

        private Random random = new();
        public async IAsyncEnumerable<GpsData> GetGpsPosition([EnumeratorCancellation] CancellationToken cancellationToken = default)
        {
            while (true)
            {
                await Task.Delay(500, cancellationToken);
                yield return new GpsData(random.Next(-90, 90), random.Next(-90, 90));
            }
        }

    }
}
