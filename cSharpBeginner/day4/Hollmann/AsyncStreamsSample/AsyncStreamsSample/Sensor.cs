using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncStreamsSample
{

    public class Sensor
    {
        public async IAsyncEnumerable<string> GetSensorData([EnumeratorCancellation] CancellationToken token = default)
        {
            int progress = 10;

            while (true)
            {
                progress += 10;
                await Task.Delay(1000,token) ;
                if (progress > 100) throw new OperationCanceledException("Loading done!");
                // token.ThrowIfCancellationRequested()
                yield return $"Loading Data - Progress: {progress}%"; ;
            }
        }
    }
}
