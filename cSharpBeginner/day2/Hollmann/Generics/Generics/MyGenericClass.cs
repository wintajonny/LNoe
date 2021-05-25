using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class MyGenericClass<T>
        where T : IDisplayAble
    {
        private T[] _items;

        public MyGenericClass(int size)
        {
            _items = new T[size];
        }

        public void SetItem(int index, T item)
        {
            _items[index] = item;
        }

        public T GetItem(int index)
        {
            return _items[index];
        }

        public void ShowAllItems()
        {
            foreach (var item in _items)
            {
                item.Display();
            }
        }
    }
}
