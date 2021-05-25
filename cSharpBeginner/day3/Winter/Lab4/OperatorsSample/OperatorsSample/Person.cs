using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSample
{
    class Person : IEquatable<Person>
    {
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static bool operator ==(Person left, Person right) => left.FirstName.Equals(right.FirstName) && left.LastName.Equals(right.LastName);

        public static bool operator !=(Person left, Person right) => !(left.FirstName.Equals(right.FirstName) && left.LastName.Equals(right.LastName));

        public bool Equals(Person other)
        {
            if(this.FirstName == other.FirstName && this.LastName == other.LastName)
            {
                return true;
            } else
            {
                return false;
            }
        }

    }
}
