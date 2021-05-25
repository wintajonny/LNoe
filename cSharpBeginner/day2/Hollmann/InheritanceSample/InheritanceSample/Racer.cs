using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample
{
    class Racer : Person
    {
        public Racer(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public override string Drive()
        {
            return $"{FirstName} {LastName} drives fast";
        }

    }
}
