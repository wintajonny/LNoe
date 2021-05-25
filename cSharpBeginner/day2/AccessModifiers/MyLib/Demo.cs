using System;

namespace MyLib
{
    public class Demo
    {
        private int internValue = 1;
        protected int MyProtected { get; set; }
        public int MyPublic { get; set; }
        internal int MyInternal { get; set; }
        internal protected int MyInternalProtected { get; set; }
    }


    public class MyDerived : Demo
    {
        public void Foo()
        {
            MyProtected = 2;

        }
    }


    internal class MyInternal
    {
        public void Foo()
        {
            Demo d1 = new();
            d1.MyInternal = 3;
            d1.MyInternalProtected = 4;
        }
    }
}
