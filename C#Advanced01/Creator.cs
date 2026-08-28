using System;
using System.Collections.Generic;
using System.Text;

namespace C_Advanced01
{
    internal class Creator<T> where T : new()
    {
        public T Build() => new T();

    }
}
