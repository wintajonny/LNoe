using System;

namespace Command_line_arguments__user_input
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 0;
            int secondNumber = 0;
            var Ergebnis = 0;
            if (args.Length > 2)
            {
                Console.WriteLine("Too much numbers. Only two numbers are allowed");
            }
            else if (args.Length == 1)
            {
                firstNumber = int.Parse(args[0]);
                Console.WriteLine("One number is missing! Please type in your second number.");
                secondNumber = int.Parse(Console.ReadLine());
                Ergebnis = firstNumber + secondNumber;

                Console.WriteLine("1. " + firstNumber + "\n2. " + secondNumber + "\nErgebnis: " + Ergebnis);
            }
            else if (args.Length == 0)
            {
                firstNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("One number is missing! Please type in your second number.");
                secondNumber = int.Parse(Console.ReadLine());
                Ergebnis = firstNumber + secondNumber;
                Console.WriteLine("1. " + firstNumber + "\n2. " + secondNumber + "\nErgebnis: " + Ergebnis);

            }
            else
            {
                    Ergebnis = int.Parse(args[0]) + int.Parse(args[1]);
                    Console.WriteLine(Ergebnis);
            }

        }
    }
    
}
