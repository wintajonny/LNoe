using DataLib;
using System;
using System.Linq.Expressions;

namespace ExpressionsSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Expression<Func<Racer, bool>> q1 = r => r.Country == "Brazil" && r.Wins > 6;

            
        }
    }
}
