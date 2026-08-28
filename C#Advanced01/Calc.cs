using System;
using System.Collections.Generic;
using System.Text;

namespace C_Advanced01
{
    internal class Calc<T> where T:struct
    {
        public T Value { get; set; }
    }
}
