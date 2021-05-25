using System;

namespace Structs
{
    class Program
    {

        public struct MyStruct
        {
            public int var1;
        }
        static void Main(string[] args)
        {
            MyStruct yourStruct = new();
            yourStruct.var1 = 5;
            Console.WriteLine(yourStruct.var1);
            ChangeStruct(ref yourStruct);
            Console.WriteLine(yourStruct.var1);
        }
        public static void ChangeStruct(ref MyStruct a)
        {
            a.var1 = 10;

        }
        
    }
}
