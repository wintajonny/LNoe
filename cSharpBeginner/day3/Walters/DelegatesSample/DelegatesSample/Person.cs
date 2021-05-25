using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesSample
{
    public class Person : IComparable<Person>, IFormattable
    {
        public Person(string first, string last) => (FirstName, LastName) = (first, last);

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int CompareTo(Person? other) => this.ToString().CompareTo(other?.ToString());

        public void Display() => Console.WriteLine(this);

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
