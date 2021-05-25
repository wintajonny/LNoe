using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGenericSample
{
    public interface IDisplayAble
    {
        void Display();
    }


    public class MyCollection<T>
        where T : IDisplayAble
    {
        private T[] _items;

        public MyCollection(int size)
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
