using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab2
{
    class BusinessEmployee : Employee
    {
        public double BonusBudget { get; set; }

        public BusinessEmployee(string name) : base(name, 50000)
        {
            BonusBudget = 1000;
        }

        public override string employeeStatus()
        {
            return ToString() + $" has a budget of {BonusBudget}";
        }
    }
}
