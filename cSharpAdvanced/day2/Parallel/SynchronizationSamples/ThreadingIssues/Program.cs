﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingIssues
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                ShowUsage();
                return;
            }

            switch (args[0].ToLower())
            {
                case "-d":
                    Deadlock();
                    break;
                case "-r":
                    RaceConditions();
                    break;
                default:
                    ShowUsage();
                    break;
            }

            Console.ReadLine();
        }

        private static void ShowUsage()
        {
            Console.WriteLine($"Usage: ThreadingIssues options");
            Console.WriteLine();
            Console.WriteLine("options:");
            Console.WriteLine("\t-d\tCreate a deadlock");
            Console.WriteLine("\t-r\tCreate a race condition");
        }

        public static void RaceConditions()
        {
            StateObject state = new();
            for (int i = 0; i < 2; i++)
            {
                Task.Run(() => new TaskWithRaceCondition().RaceCondition(state));
            }
        }

        public static void Deadlock()
        {
            StateObject s1 = new();
            StateObject s2 = new();
            Task.Run(() => new TaskWithDeadlock(s1, s2).Deadlock1());
            Task.Run(() => new TaskWithDeadlock(s1, s2).Deadlock2());

            Task.Delay(10000).Wait();
        }
    }
}
