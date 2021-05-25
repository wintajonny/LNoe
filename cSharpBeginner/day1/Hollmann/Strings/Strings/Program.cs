using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a string:");
            var inputString = Console.ReadLine();
            if (string.IsNullOrEmpty(inputString)) Console.WriteLine("No input was given, therefore no action has been taken.");
            int cutLength;
            if (inputString.Length >= 3)
            {
                //let's try to cut the string in 3 equally long parts
                cutLength = inputString.Length / 3;
            }
            else
            {
                //we just have 1 or 2 chars let's print 1 by 1
                cutLength = 1;
            }
            string[] parts = new string[3];

            if (cutLength == 1)
            {
                foreach (var s in inputString)
                {
                    Console.WriteLine(s);
                }
            }
            else
            {
                //we really use ranges
                string firstRange = inputString[..cutLength];
                string secondRange = inputString[cutLength..^cutLength];
                string thirdRange = inputString[^cutLength..^0];
                Console.WriteLine(firstRange);
                Console.WriteLine(secondRange);
                Console.WriteLine(thirdRange);
            }

        }
    }
}
