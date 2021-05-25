using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourcesSample
{
    class InnerResource : IDisposable
    {
        public InnerResource()
        {
            Console.WriteLine("allocate inner resource native memory");
            // GC.AddMemoryPressure(1000000000);
        }

        ~InnerResource()  // Finalize
        {
            Dispose();
        }

        public void Dispose()
        {
            Console.WriteLine("release inner resource native memory");
            GC.SuppressFinalize(this);
        }

        public void Bar()
        {
            Console.WriteLine("InnerResource.Bar");
        }
    }
}
