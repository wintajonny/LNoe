using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysSample
{
    class HelloWorld  : IEnumerable<string>
    {
        public IEnumerator<string> GetEnumerator()
        {
            yield return "Hello";
            yield return "World";
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    }
}
