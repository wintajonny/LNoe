using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourcesSample
{
    public class MyResource : IDisposable
    {
        private InnerResource _inner;
        private bool _isDisposed = false;

        public MyResource()
        {
            _inner = new InnerResource();
            Console.WriteLine("allocate native memory");
            // GC.AddMemoryPressure(1000000000);
        }

        ~MyResource()  // Finalize
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
        }

        protected virtual void Dispose(bool isDisposing)
        {
            if (isDisposing)
            {
                _inner.Dispose();
            }

            Console.WriteLine("release native memory");
            _isDisposed = true;

            GC.SuppressFinalize(this);
        }

        public void Foo()
        {
            if (_isDisposed) throw new ObjectDisposedException(nameof(MyResource));

            Console.WriteLine("MyResource.Foo");
        }
    }
}
