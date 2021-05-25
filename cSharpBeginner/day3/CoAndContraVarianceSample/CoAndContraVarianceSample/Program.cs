using System;

namespace CoAndContraVarianceSample
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = { "one", "two", "three" };
            object[] arr2 = arr1;  // covariant
            arr2[1] = "abc";  // contravariant
            // arr2[0] = 44;
        }
    }
}
