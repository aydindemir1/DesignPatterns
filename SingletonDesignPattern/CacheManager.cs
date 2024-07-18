using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public class CacheManager
    {
        private static CacheManager instance = null;
        private static readonly object padlock = new object();
        private Dictionary<string, object> cache;

        private CacheManager()
        {
            cache = new Dictionary<string, object>();
        }

        public static CacheManager Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new CacheManager();
                    }
                    return instance;
                }
            }
        }

        public void AddItem(string key, object value)
        {
            if (!cache.ContainsKey(key))
            {
                cache[key] = value;
            }
        }

        public object GetItem(string key)
        {
            return cache.ContainsKey(key) ? cache[key] : null;
        }
    }

}
