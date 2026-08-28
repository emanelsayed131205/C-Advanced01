using System;
using System.Collections.Generic;
using System.Text;

namespace C_Advanced01
{
    public interface ILoggable
    {
        void log();
    }
    public class Manager<T> where T : class, ILoggable, new()
    {
        public T CreateAndLog()
        {
            T item = new T(); 
            item.log();       
            return item;
        }
    }

    public class Service : ILoggable
    {
        public void Log() => Console.WriteLine("Service started.");
    }
}
