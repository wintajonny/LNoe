using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysSample
{

    public class PersonComparer : IComparer<Person>
    {
        public int Compare(Person? x, Person? y)
        {
            if (x == y)
            {
                return 0;
            }
            if (x != y)
            {
                return -1;
            }

            return 1;
        }

        
    }
    public class Person : IComparable<Person>, IFormattable, IEquatable<Person>
    {
        public Person(string first, string last) => (FirstName, LastName) = (first, last);

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int CompareTo(Person? other) => this.ToString().CompareTo(other?.ToString());

        public void Display()
        {
            Console.WriteLine(this);
        }

        public bool Equals(Person? other)
        {
            //return (this.FirstName, this.LastName) == (other?.FirstName, other?.LastName);
            return (this.ToString() == other?.ToString());
        }

        public override string ToString() => $"{FirstName} {LastName}";

        public string ToString(string? format, IFormatProvider? formatProvider) => 
            format switch
            {
                "F" => FirstName,
                "L" => LastName,
                "A" => ToString(),
                _ => ToString()
            };
    }
}
