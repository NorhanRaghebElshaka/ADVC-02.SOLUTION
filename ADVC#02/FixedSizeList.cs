using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADVC_02
{
    public class FixedSizeList<T>
    {
        private T[] _items;
        private int _count;

        public FixedSizeList(int capacity)
        {
            _items = new T[capacity];
            _count = 0;
        }

        public void Add(T item)
        {
            if (_count == _items.Length)
            {
                throw new Exception("List is full.");
            }
            _items[_count++] = item;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= _count)
            {
                throw new IndexOutOfRangeException("Invalid index.");
            }
            return _items[index];
        }
    }
}
