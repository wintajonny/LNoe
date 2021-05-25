using System;

namespace StructsSample
{
    class Program
    {

        public struct MyStruct
        {
            public int data;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MyStruct myStruct = new();
            myStruct.data = 1;
            Console.WriteLine($"OriginalValue: {myStruct.data}");
            ChangeMyStruct(ref myStruct);
            Console.WriteLine($"ReceivedValue: {myStruct.data}");

        }

        public static void ChangeMyStruct(ref MyStruct myStruct)
        {
            myStruct.data = 5;
            Console.WriteLine($"ChangedValue: {myStruct.data}");
        }
    }
}
