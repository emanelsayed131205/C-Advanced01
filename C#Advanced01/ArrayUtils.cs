using System;
using System.Collections.Generic;
using System.Text;

namespace C_Advanced01
{
    internal class ArrayUtils
    {
        public static T FindMax<T>(T[] items) where T : IComparable<T>
        {
            if (items == null || items.Length == 0)
                throw new ArgumentException("Array cannot be null or empty.");

            T max = items[0];

            for (int i = 1; i < items.Length; i++)
            {
                if (items[i].CompareTo(max) > 0)
                {
                    max = items[i];
                }
            }

            return max;
        }
    }
}
