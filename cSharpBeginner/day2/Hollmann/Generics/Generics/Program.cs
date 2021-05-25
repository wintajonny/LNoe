using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            MyGenericClass<Person> newPersons = new(3);
            
            //mixing up the indexes for fun
            newPersons.SetItem(2, new Person("Christian", "Maslo"));
            newPersons.SetItem(0, new Person("Alex", "Hollmann"));
            newPersons.SetItem(1, new Person("Mario", "P"));
            newPersons.ShowAllItems();
        }
    }
}
