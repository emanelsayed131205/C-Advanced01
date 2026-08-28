using System;
using System.Collections.Generic;
using System.Text;

namespace C_Advanced01
{
    internal class Cache<Tkey,Tvalue> where Tkey:notnull
    {
        private class CacheItem
        {
            public Tvalue Value { get; set; }
            public DateTime Expiration { get; set; }

            public CacheItem(Tvalue value, TimeSpan ttl)
            {
                Value = value;
                Expiration = DateTime.UtcNow.Add(ttl);
            }

            public bool IsExpired => DateTime.UtcNow > Expiration;
        }

        private readonly Dictionary<Tkey, CacheItem> _store = new();

        
        public void Add(Tkey key, Tvalue value, TimeSpan timeToLive)
        {
            _store[key] = new CacheItem(value, timeToLive);
        }

        
        public bool Get(Tkey key, out Tvalue value)
        {
            if (_store.TryGetValue(key, out var item) && !item.IsExpired)
            {
                value = item.Value;
                return true;
            }

            
            _store.Remove(key);
            value = default!;
            return false;
        }

        
        public bool Contains(Tkey key)
        {
            return Get(key, out _);
        }

        
        public bool Remove(Tkey key)
        {
            return _store.Remove(key);
        }

    }
}
