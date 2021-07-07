using System;

namespace Mod2_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {

            var employee1 = new TechnicalEmployee("Theresa");
            var employee2 = new TechnicalEmployee("Benedikt");
            var employee3 = new BusinessEmployee("Gustav");


            Console.WriteLine(employee1.EmployeeStatus());
            Console.WriteLine(employee2.EmployeeStatus());
            Console.WriteLine(employee3.EmployeeStatus());




        }
    }
}
