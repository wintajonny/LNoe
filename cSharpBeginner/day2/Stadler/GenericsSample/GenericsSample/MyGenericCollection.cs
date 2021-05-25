using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsSample
{
    public interface IDisplayAble
    {
        void Display();
    }
    public class MyGenericCollection<T>
        where T : IDisplayAble
    {
        public void Add(T input) { }
    }
}
