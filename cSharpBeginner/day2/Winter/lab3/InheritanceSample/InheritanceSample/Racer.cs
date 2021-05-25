using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample
{
    class Racer : Person, IDrive
    {
        public Racer(string firstName, string lastName) : base(firstName, lastName)
        {
        }
    }
}
