using System;
using System.Reflection;

namespace MyAddInHost
{
    class Program
    {
        static void Main(string[] args)
        {

            //with reflection
            //var calc = GetCalculator();
            //if (calc is not null)
            //{
            //    Type t = calc.GetType();
            //    MethodInfo? methodInfo = t.GetMethod("Add");
            //    object[] input = { 38, 4 };
            //    object result = methodInfo?.Invoke(calc, input);
            //    Console.WriteLine(result);
            //}

            // dynamic
            dynamic calc = GetCalculator();
            if (calc is null) return;

            dynamic result = calc.Multiply(11, 22);
            Console.WriteLine(result);
        }

        static object? GetCalculator()
        {
            Assembly calcAssembly = Assembly.LoadFrom("c:/addins/Calculator.dll");
            return calcAssembly.CreateInstance("Calculator.Math");
        }
    }
}
