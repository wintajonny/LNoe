using System;

namespace Mod03_Lab01HW
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                validateStudentBirthday();

            } catch (NotImplementedException)
            {
                Console.WriteLine("NotImplementedException catched");
            }
            finally
            {
                Console.WriteLine("Im in finally");
            }

            string firstName;
            string lastName;
            DateTime birthdate;


            (firstName, lastName, birthdate) = GetStudentInformation();

            PrintStudentDetails(firstName, lastName, birthdate);


        }




        static (string, string, DateTime) GetStudentInformation()
        {
            Console.WriteLine("Enter the student's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the student's birth date");
            DateTime birthdate = DateTime.Parse(Console.ReadLine());
            // Code to finish getting the rest of the student data

            return (firstName, lastName, birthdate);
        }

        static void PrintStudentDetails(string first, string last, DateTime birthday)
        {
            Console.WriteLine("{0} {1} was born on: {2}", first, last, birthday.ToString());
        }


        static void validateStudentBirthday()
        {
            throw new NotImplementedException();
        }

    }
}
