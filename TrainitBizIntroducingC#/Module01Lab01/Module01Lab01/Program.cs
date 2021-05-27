using System;

namespace Module01Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            // create variables of different data types
            // initialize with a "default" value
            string firstName = "";
            string lastName = "";
            int age = 0;
            string street = "";
            string city = "";
            string country = "";
            DateTime birthDate;

            // Assign some values
            firstName = "Tom";
            lastName = "Thumb";
            street = "123 Fourth Street";
            city = "Anytown";
            country = "MyCountry";
            birthDate = new DateTime(1998, 11, 2);
            age = (DateTime.Now - birthDate).Days/365;

            // output to the console window

            // use simple output with just variable name
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);

            // use placeholder style
            Console.WriteLine($"{age} years old.");

            // use string concatenation
            Console.WriteLine(street + ", " + city + ", " + country);

            // use string interpolation
            // NOTE: This line of code only works with Visual Studio 2015 or C# 6.0 and later.
            // If you are using an earlier version, then comment out this line of code.
            Console.WriteLine($"Born on {birthDate}");

        }
    }
}
