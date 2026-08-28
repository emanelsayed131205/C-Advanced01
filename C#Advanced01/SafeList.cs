using System;
using System.Collections.Generic;
using System.Text;

namespace C_Advanced01
{
    internal class SafeList<T>
    {
        private List<T> _items = new List<T>();

        public void Add(T item) => _items.Add(item);

        public T Get(int index)
        {
           
            if (index >= 0 && index < _items.Count)
                return _items[index];

            return default;
        }

    }
}
