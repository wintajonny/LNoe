using System;

namespace userInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User Input Lab01");

            int firstParameter;
            int secondParameter;


            if(args.Length > 2)
            {
                Console.WriteLine("Error: Please enter two parameters");
            } else if(args.Length < 2)
            {
                switch (args.Length)
                {
                    case 0:
                        Console.WriteLine("First Parameter");
                        firstParameter = int.Parse(Console.ReadLine());
                        Console.WriteLine("Second Parameter");
                        secondParameter = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Your result is {firstParameter + secondParameter}");
                        break;
                    case 1:
                        firstParameter = int.Parse(args[0]);
                        Console.WriteLine("Second Parameter");
                        secondParameter = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Your result is: {firstParameter + secondParameter}");
                        break;
                    default:
                        break;
                }

            }
            else
            {
                firstParameter = int.Parse(args[0]);
                secondParameter = int.Parse(args[1]);
                Console.WriteLine($"Your result is: {firstParameter + secondParameter}");
            }
        }
    }
}
