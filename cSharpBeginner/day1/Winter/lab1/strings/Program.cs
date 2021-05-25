using System;


namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String");
            string enteredString = Console.ReadLine();

            Console.WriteLine("The entered string is: " + enteredString);
            Console.WriteLine("The first letter is:" + enteredString[0]);
            Console.WriteLine("The last letter is:" + enteredString[^1]);
            Console.WriteLine("The middle part of the string is:" + enteredString[1 .. ^1]);
            Console.WriteLine("the word between w and d is: " + enteredString[enteredString.IndexOf("w") .. (enteredString.IndexOf("d")+1)]);



        }
    }
}
