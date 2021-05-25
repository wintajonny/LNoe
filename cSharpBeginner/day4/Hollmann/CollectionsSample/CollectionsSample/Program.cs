using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsSample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list1 = new List<string>();
            list1.AddRange(Enumerable.Range(1, 5000).Select(i => new string($"team {i}")));

            Console.WriteLine(list1.Capacity);

            // capacity is 5000 + 3192

            List<string> list2 = new(5000);
            list1.AddRange(Enumerable.Range(1, 5000).Select(i => new string($"team {i}")));

            Console.WriteLine(list2.Capacity);

            // we can set the capacity to be 5000 and it will stay there


            LinkedList<int> lL = new();
            var treeElement1 = lL.AddLast(1);
            var treeElement2 = lL.AddAfter(treeElement1, 3);
            var treeElement3 = lL.AddBefore(treeElement2, 2);

            lL.Remove(treeElement2);

            foreach (var node in lL)
            {
                Console.WriteLine(node);
            }
            lL.Remove(treeElement3);
            Console.WriteLine("-----");
            foreach (var node in lL)
            {
                Console.WriteLine(node);
            }
        }
    }
}
