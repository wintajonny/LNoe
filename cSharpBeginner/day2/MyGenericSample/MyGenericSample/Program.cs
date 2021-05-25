using System;

namespace MyGenericSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyCollection<int> coll1 = new(5);
            //coll1.SetItem(0, 4);
            //coll1.SetItem(1, 8);

            //MyCollection<string> coll2 = new(3);
            //coll2.SetItem(0, "abc");

            MyCollection<Person> coll3 = new(3);
            coll3.SetItem(0, new Person("tom", "Turbo"));
            coll3.SetItem(1, new Person("Mickey", "Mouse"));
            coll3.SetItem(2, new Person("Bruce", "Wayne"));
            coll3.ShowAllItems();

            // MyCollection<string> coll4 = new(3);
        }
    }
}
