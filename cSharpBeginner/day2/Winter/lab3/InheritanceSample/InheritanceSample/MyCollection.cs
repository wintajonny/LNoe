using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample
{
    class MyCollection<T>
        where T:IDrive
    {

        private T[] items;
        public MyCollection(int size)
        {
            items = new T[size];
        }

        public void SetItem(int index, T item)
        {
            items[index] = item;
        }


        public void displayDriverSpeeds()
        {
            foreach (T item in items)
            {
                item.Drive();
            }
        }

    }
}
