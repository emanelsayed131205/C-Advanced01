using System;
using System.Collections.Generic;
using System.Text;

namespace C_Advanced01
{
    internal class Pair <Tkey ,Tvalue>
    {
        public Tkey Key {  get; set; }
        public Tvalue Value { get; set; }

        //ctr
        public Pair(Tkey key ,Tvalue value)
        {
            Key= key;
            Value= value;
        }
    }
}
