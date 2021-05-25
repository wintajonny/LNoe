using System;

namespace StructsSample
{
    struct MyStruct
    {
        public int Member1;

        public MyStruct(int member1)
        {
            Member1 = member1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyStruct myStruct = new(111);

            MachWasMitDemStruct(myStruct);

            Console.WriteLine(myStruct.Member1);
        }

        static void MachWasMitDemStruct(MyStruct strct)
        {
            strct.Member1 = 222;
            Console.WriteLine(strct.Member1.ToString());
        }
        
    }
}
