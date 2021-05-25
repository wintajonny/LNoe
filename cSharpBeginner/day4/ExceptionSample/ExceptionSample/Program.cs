using System;

namespace ExceptionSample
{
    class Program
    {
        static void Main(string[] args)
        {
            OuterMethod();
        }

        static void OuterMethod()
        {
            try
            {
                Callinanyway();
            }
            catch (MySampleException)
            {
                Console.WriteLine("my sample exception caught");
            }
            Console.WriteLine("at end outer method");
        }

        static void Callinanyway()
        {
            try
            {
                Console.WriteLine("enter throw or not");
                string input = Console.ReadLine();
                if (input == "throw")
                {
                    throw new MySampleException();
                }
            }
            finally
            {
                Console.WriteLine("in finally");
            }
            Console.WriteLine("at end");
        }

        static void CallSomething()
        {
            try
            {
                string input = Console.ReadLine();
                int x = int.Parse(input);
                Console.WriteLine("CallSomething");
                ThrowSomething();
            }
            catch (MySampleException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                throw new MySampleException("some error", ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {

            }
        }

        static void ThrowSomething()
        {
            throw new MySampleException("Something bad happened");
        }
    }
}
