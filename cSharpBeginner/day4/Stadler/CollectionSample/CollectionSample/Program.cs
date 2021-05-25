using System;
using System.Collections.Generic;

namespace CollectionSample
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] exampleWords = { "Hello", "holla", "seawas", "bonjour" };
            
            LinkedList<string> words = new(exampleWords);

            DisplayLinkedList(words, "The inital set of words");

            LinkedListNode<string> node = words.AddFirst("Hallo");

            DisplayLinkedList(words, "Change the first item");

            words.AddAfter(node, "grüßgott");

            DisplayLinkedList(words, "Inserted item after the first item");

            words.AddLast("adios");

            DisplayLinkedList(words, "Last item added");

            words.RemoveLast();
            words.RemoveFirst();

            DisplayLinkedList(words, "First an last item removed");

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
