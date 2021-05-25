using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Person : IComparable<Person>, IFormattable, IEquatable<Person>
    {
        public Person (string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        string FirstName { get; set; }
        string LastName { get; set; }

        public int CompareTo(Person? other) =>
            this.LastName.CompareTo(other?.LastName);

        public void Display()
        {
            Console.WriteLine(this);
        }

        public bool Equals(Person? other)
        {
            return (this.ToString() == other?.ToString());
        }

        public static bool operator == (Person first, Person? other)
        {
            return first.ToString() == other?.ToString();
        }
        public static bool operator != (Person first, Person? other)
        {
            return !(first.ToString() == other?.ToString());
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
