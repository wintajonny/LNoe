using System;

namespace InheritanceSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons =
                {
                new Person("Alexander","Hollmann"),
                new Racer("Christian","Maslo"),
                new Racer("Mario","P"),
                new Person("Erik","Prachtl")
                };

            foreach (var p in persons)
            {
                ShowPerson(p);
            }
            

        }

        static void ShowPerson(Person p)
        {
            Console.WriteLine($"{p.GetType()}:" + p.Drive());
        }
    }
}
