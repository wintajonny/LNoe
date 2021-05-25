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
    {
        private T[] _items;

        public MyCollection(int size)
        {
            _items = new T[size];
        }


        public T this[int index]
        {
            get => _items[index];
            set => _items[index] = value;
        }


        //public void SetItem(int index, T item)
        //{
        //    _items[index] = item;
        //}

        //public T GetItem(int index)
        //{
        //    return _items[index];
        //}



    }
}
