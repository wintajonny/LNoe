using System;
using System.Numerics;

//Console.WriteLine("Started");

//foreach (var arg in args)
//{
//    Console.WriteLine(arg);
//}

//int x1 = 3;
//{
//    x1 = 4;

//}
//Foo();

//Console.WriteLine(x1);  // 4

//int? x2 = null;

//Nullable<int> x2b = null;

//if (x2.HasValue)
//{
//    int x3 = x2.Value;
//    // use x3
//}

//#nullable disable

//string s1 = null;


//#nullable restore

//object o1 = new object();
//string? s4 = o1.ToString();

//if (s4 != null)
//{
//    string s5 = s4.ToUpper();
//    Console.WriteLine(s5);
//}

//long mynumber = 0x_12_34567_89ab_cdef;

//ushort mybinnumber = 0b_1111_1110_1101_1100;

//char c1 = 'a';
//string s2 = "a";

//// UTF8  1 byte 2 byte 3 byte 4 byte

//float f1 = 3.5F;


Console.WriteLine("enter a number");
string? input1 = Console.ReadLine();
if (int.TryParse(input1, out int aNumber))
{
    switch (aNumber)
    {
        case 1:
            Console.WriteLine("it's 1");
            break;
        case 2:
            Console.WriteLine("it's 2");
            break;
        default:
            Console.WriteLine("another number");
            break;
    }
}
//if (input1 is not null)
//{
//    // int aNumber = int.Parse(input1);


//}




void Foo()
{
    int x1 = 42;
    Console.WriteLine(x1);
}
