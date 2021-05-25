using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsSample
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list1 = new();
            list1.Add("one");
            list1.Add(2);
            list1.Add(3);

            List<string> coll1 = new(800);
            Console.WriteLine(coll1.Capacity);

            for (int i = 0; i < 1000; i++)
            {
                coll1.Add(i.ToString());
                Console.WriteLine(coll1.Capacity);
            }

            string x = coll1[823];

            coll1.Insert(333, "abc");

            var coll2 = coll1.AsReadOnly();

            LinkedList<int> myLinkedList = new();
            var node33 = myLinkedList.AddLast(33);
            var node22 = myLinkedList.AddBefore(node33, 22);
        }
    }
}
