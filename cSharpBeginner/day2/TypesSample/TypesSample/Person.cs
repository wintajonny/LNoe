using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesSample
{
    class Person
    {
        private readonly string _firstName;
        private readonly string _lastName;

        public Person(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        //public Person()
        //{
        //    _firstName = "unknown";
        //    _lastName = "unknown";
        //}

        public Person(string firstName)
            : this(firstName, "unknown")  // constructor initializer
        { }

        public string FirstName
        {
            get => _firstName;
        }

        public string FullName => $"{_firstName} {_lastName}";  // property mit get accessor
    }
}
