using System;

namespace Mod2_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {

            var employee1 = new Employee("Theresa", 2000);
            var employee2 = new TechnicalEmployee("Benedikt");
            var employee3 = new BusinessEmployee("Gustav");


            Console.WriteLine(employee1.employeeStatus());
            Console.WriteLine(employee2.employeeStatus());
            Console.WriteLine(employee3.employeeStatus());




        }
    }
}
