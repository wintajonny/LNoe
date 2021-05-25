using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncWPFApp
{
    class ComplexCalculations
    {
        public int Add(int x, int y)
        {
            Thread.Sleep(5000);
            return x + y;
        }

        public record Result(bool Completed, int Progress, int Value);

        public async IAsyncEnumerable<Result> GetAddResult(int x, int y, [EnumeratorCancellation] CancellationToken cancellationToken = default)
        {
            for (int i = 0; i < 100; i++)
            {
                await Task.Delay(50);
                yield return new Result(false, i + 1, 0);
            }
            yield return new Result(true, 100, x + y);
        }
    }
}
