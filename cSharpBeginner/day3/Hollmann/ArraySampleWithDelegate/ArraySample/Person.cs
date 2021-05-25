using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySample
{
    public class Person : IComparable<Person>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int CompareTo(Person? other)
        {
            var resultSecondCompare = this?.LastName.CompareTo(other?.LastName);
            if (resultSecondCompare == 0) return 0;
            else if (resultSecondCompare == -1) return -1;
            else return 1;
        }
    }
}
