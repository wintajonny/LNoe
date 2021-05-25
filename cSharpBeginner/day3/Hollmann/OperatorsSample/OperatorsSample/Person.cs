using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSample
{
    class Person : IEqualityComparer<Person>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public bool Equals(Person? x, Person? y)
        {
            return x?.FirstName == y?.FirstName && x?.LastName == y?.LastName;
        }

        public static bool operator ==(Person? x, Person? y) => x?.FirstName == y?.FirstName && x?.LastName == y?.LastName;

        public static bool operator !=(Person? x, Person? y) => x?.FirstName != y?.FirstName || x?.LastName != y?.LastName;

        public int GetHashCode([DisallowNull] Person obj)
        {
            throw new NotImplementedException();
        }
    }
}
