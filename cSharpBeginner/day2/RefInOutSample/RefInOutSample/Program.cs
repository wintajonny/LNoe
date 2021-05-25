using System;

namespace RefInOutSample
{
    class Test
    {
        public string? Title { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("give me a number");
            string? input = Console.ReadLine();

            // out -returns a result
            // in - readonly 
            // ref - pass by reference in + out

            string s1 = "a string";
            InSample(s1);

            if (int.TryParse(input, out int result))
            {
                Console.WriteLine("this was an int");
                Console.WriteLine($"result: {result}");
            }

            string s2 = "another string";
            RefSample(ref s2);
            Console.WriteLine(s2);

            string s3;
            // RefSample(s3);
            OutSample(out s3);

        }

        static void InSample(in string s)  
        {
            // s = "change"; // not allowed
        }

        static void RefSample(ref string s)
        {
            s = "a change";
        }

        static void OutSample(out string s)
        {
            s = "init";
        }
    }
}
