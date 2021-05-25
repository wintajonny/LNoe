using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            string arg1 = "";
            string arg2 = "";

            if(args.Length == 2)
            {
                arg1 = args[0];
                arg2 = args[1];
            }
            else if (args.Length == 0)
            {
                Console.WriteLine("Gib das erste Argument ein:");
                arg1 = Console.ReadLine();
                Console.WriteLine("Gib das zweite Argument ein:");
                arg2 = Console.ReadLine();
            }
            else if (args.Length == 1)
            {
                arg1 = args[0];
                Console.WriteLine("Gib das zweite Argument ein:");
                arg2 = Console.ReadLine();
            }
            else if(args.Length > 2)
            {
                Console.WriteLine("Zu viele Argumente.");
            }

            int.TryParse(arg1, out int i1);
            int.TryParse(arg2, out int i2);


            Console.WriteLine($"Die Summe ist {i1 + i2}");
        }
    }
}
