using System;

namespace InheritanceSample
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person("Thomas", "Winter");
            Person p2 = new Person("Bernhard", "Piendl");
            Person p3 = new Person("Jonas", "Stadler");
            Racer r1 = new Racer("Sebastian", "Vettel");
            Racer r2 = new Racer("Nikki", "Lauda");
            Racer r3 = new Racer("Lewis", "Hamilton");


            Person[] personArray = new []
            {
                p1,
                p2,
                p3,
                r1,
                r2,
                r3
            };

            //foreach(Person p in personArray)
            //{
            //    ShowPerson(p);
            //}


            MyCollection<IDrive> myCollection = new MyCollection<IDrive>(3);
            //myCollection.SetItem(0, p1);
            //myCollection.SetItem(1, p2);
            //myCollection.SetItem(2, p3);
            myCollection.SetItem(0, r1);
            myCollection.SetItem(1, r2);
            myCollection.SetItem(2, r3);

            myCollection.displayDriverSpeeds();
        }

    }
}
