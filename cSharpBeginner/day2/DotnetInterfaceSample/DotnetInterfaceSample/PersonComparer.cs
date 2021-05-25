using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetInterfaceSample
{
    public enum PersonCompareType
    {
        FirstName,
        LastName
    }

    public class PersonComparer : IComparer<Person>
    {
        private readonly PersonCompareType _compareType;
        public PersonComparer(PersonCompareType compareType) => _compareType = compareType;

        public int Compare(Person? x, Person? y) => _compareType switch
        {
            PersonCompareType.FirstName => string.Compare(x?.FirstName, y?.FirstName),
            PersonCompareType.LastName => string.Compare(x?.LastName, y?.LastName),
            _ => throw new InvalidOperationException("this enum value is not implemented")
        };
    }
}
