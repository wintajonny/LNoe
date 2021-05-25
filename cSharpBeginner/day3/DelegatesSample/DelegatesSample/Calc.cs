using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesSample
{
    class Calc
    {
        public int Add(int x, int y) => x + y;
        public int Subtract(int x, int y) => x - y;

        public void AddUI(int x, int y)
        {
            Console.WriteLine($"the result of {x} + {y} is {x + y}");
        }


        public void SubtractUI(int x, int y)
        {
            Console.WriteLine($"the result of {x} - {y} is {x - y}");
        }
    }
}
