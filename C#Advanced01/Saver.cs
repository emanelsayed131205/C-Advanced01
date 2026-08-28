using System;
using System.Collections.Generic;
using System.Text;

namespace C_Advanced01
{
    internal class Saver<T> where T : IDisposable
    {
        public void CleanUp(T item) => item.Dispose();
    }
}
