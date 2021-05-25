using MyGenericSample;
using System;

namespace OperatorsSample
{
    class Program
    {
        static void Main(string[] args)
        {
            checked
            {
                int x = int.MaxValue;
                x++;


                Console.WriteLine(x);
            }

            MyCollection<string> coll1 = new MyCollection<string>(4);
            coll1[0] = "one";
            coll1[1] = "two";
            string s = coll1[0];
           
        }

        static void WorkWithShapes(Shape shape)
        {
            if (shape is null) throw new ArgumentNullException(nameof(shape));

            Rectangle? r1 = shape as Rectangle;
            if (r1 is not null)
            {
                Console.WriteLine("r1 is a rectangle");
            }

            if (shape is Rectangle r2)
            {
                r2.MyRectangle();

                
            }
        }

       
    }
}
