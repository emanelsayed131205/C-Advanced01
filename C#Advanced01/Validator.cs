using System;
using System.Collections.Generic;
using System.Text;

namespace C_Advanced01
{
    internal class Validator<T> where T : class
    {
        public bool IsNull(T item) => item == null;
    }
}
