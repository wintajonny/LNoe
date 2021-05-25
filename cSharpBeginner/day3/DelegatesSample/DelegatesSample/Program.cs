using System;

namespace DelegatesSample
{
    public delegate int MathOp(int x, int y);
    public delegate void MathOpUI(int x, int y);

    class Program
    {
        static void Main(string[] args)
        {
            Calc c = new();
            int result = c.Add(3, 4);

            MathOp op1 = new MathOp(c.Add);
            result = op1.Invoke(38, 4);
            Console.WriteLine(result);

            // op1 = new MathOp(c.Subtract);
            op1 = c.Subtract;
            result = op1(44, 2);
            Console.WriteLine(result);

            op1 += c.Add;

            MathOpUI opui = c.AddUI;
            opui += c.SubtractUI;
            opui(22, 11);



            Func<int, int, int> f1 = c.Add;
            result = f1(18, 24);

            Action<int, int> f2 = c.AddUI;
            f2(18, 24);

        }
    }
}
