using System;
using System.Collections.Generic;
using System.Text;

namespace C_Advanced01
{
    internal class Container <T>
    {
        private readonly List<T> _list = new();
        public void Add(T list) => _list.Add(list);       
        public T Get (int index) => _list[index];       
        
    }
}
