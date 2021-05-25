using System;

namespace CommandLineArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 2)
            {
                Console.WriteLine("Too many arguments provided. Only 2 arguments are allowed!");
                return;
            }
            var firstNumber = 0;
            var secondNumber = 0;
            if (args.Length >= 1)
            {
                if (int.TryParse(args[0], out firstNumber))
                {
                    //all good we got our first number
                }
                else
                {
                    //parse did not work - request number again
                    firstNumber = EnterNumber(1);
                }
               
                if (args.Length == 2 && int.TryParse(args[1], out secondNumber))
                {
                    //all good we got our second number
                }
                else
                {
                    //parse did not work - request number again
                    secondNumber = EnterNumber(2);
                }

            }
            else
            {
                // no arguments provided so input both numbers
                string firstInput;
                do
                {
                    Console.WriteLine("Please input your first number:");
                    firstInput = Console.ReadLine();

                } while (!int.TryParse(firstInput, out firstNumber));

                secondNumber = EnterNumber(2);
            }

            // do the actual calculation

            var sum = firstNumber + secondNumber;

            Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is {sum}!");
            

        }


        static int EnterNumber(int position)
        {
            
            string input;
            int tempNumber;

            string positionString = position switch
            {
                1 => "first",
                2 => "second",
                _ => "invalid"
            };

            if (positionString == "invalid") throw new ArgumentException("An unknown position for which number should be entered was provided!");

            do
            {
                Console.WriteLine($"Please input your {positionString} number:");
                input = Console.ReadLine();

            } while (!int.TryParse(input, out tempNumber));

            return tempNumber;
        }
    }
}
