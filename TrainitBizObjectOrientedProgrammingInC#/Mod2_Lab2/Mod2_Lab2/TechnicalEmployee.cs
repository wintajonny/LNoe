using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab2
{
    class TechnicalEmployee : Employee
    {

        public int SuccessfulCheckIns { get; set; }

        public TechnicalEmployee(string name) : base(name, 7500)
        {
            SuccessfulCheckIns = 5;
        }

        public override string EmployeeStatus()
        {
            return ToString() + $" has {SuccessfulCheckIns} successful check ins";
        }

    }
}
