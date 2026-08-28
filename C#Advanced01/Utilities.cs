using System;
using System.Collections.Generic;
using System.Text;

namespace C_Advanced01
{
    internal class Utilities
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
