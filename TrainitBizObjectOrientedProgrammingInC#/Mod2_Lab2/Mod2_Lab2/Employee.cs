using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab2
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public double BaseSalary { get; set; }
        public int Id { get; set; }
        private static int employeeCount = 1;

        public Employee(String name, double baseSalary)
        {
            Name = name;
            BaseSalary = BaseSalary;
            Id = employeeCount++;
        }

        public double GetBaseSalary()
        {
            return BaseSalary;
        }

        public String GetName()
        {
            return Name;
        }

        public int GetEmployeeId()
        {
            return Id;
        }

        public override string ToString()
        {
            return Id + " " + Name;
        }

        public abstract String EmployeeStatus();
    }
}
