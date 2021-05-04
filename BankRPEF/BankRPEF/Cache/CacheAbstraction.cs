using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankRPEF.Cache.BankRPEF.Cache;

namespace BankRPEF.Cache
{
    public class CacheAbstraction
    {
        IWebCache _iwebCache = null;
        public CacheAbstraction(IWebCache iwebc)
        {
            _iwebCache = iwebc;
        }
        public CacheAbstraction() // default cache provider
                                  // : this(new HttpContextCacheAdapter())
        : this(new CouchBaseCacheAdapter())
        //: this(new NullObjectCache())
        {
        }
        public void Remove(string key)
        {
            _iwebCache.Remove(key);
        }
        public void Insert(string key, object obj)
        {
            _iwebCache.Store(key, obj);
        }
        public T Retrieve<T>(string key)
        {
            return _iwebCache.Retrieve<T>(key);
        }
    }

}
}
