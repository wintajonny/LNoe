using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionRangeSample
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] exampleWords = { "hello", "holla", "seawas", "bonyour" };
            LinkedList<string> words = new(exampleWords);

            DisplayLinkedList(words, "The initial set of words");

            LinkedListNode<string> node = words.AddFirst("hallo");

            DisplayLinkedList(words, "Changed the first item");

            words.AddAfter(node, "grüßgott");

            DisplayLinkedList(words, "Inserted item after the first item");

            words.AddLast("adios");

            DisplayLinkedList(words, "Last item added");

            words.RemoveLast();
            words.RemoveFirst();

            DisplayLinkedList(words, "First and last item removed");

        }

        public static void DisplayLinkedList(LinkedList<string> list, string text)
        {
            Console.WriteLine(text);
            foreach(string s in list)
            {
                Console.WriteLine(s);
            }
        }

    }
}
