using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysSample
{
    public class Person : IComparable<Person>, IFormattable, IEquatable<Person>, IComparer<Person>
    {
        public Person(string first, string last) => (FirstName, LastName) = (first, last);

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Compare(Person? x, Person? y)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(Person? other) => this.ToString().CompareTo(other?.ToString());

        public void Display()
        {
            Console.WriteLine(this);
        }

        public bool Equals(Person? other)
        {
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
