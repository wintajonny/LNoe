using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySample
{
    class PersonComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return String.Compare(x.FirstName, y.FirstName);
        }

    }
}
