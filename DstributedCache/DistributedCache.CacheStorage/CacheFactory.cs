using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DistributedCache.CacheStorage
{
    public enum CacheFlag
    {
        MemoryCache, FileCache
    }

    public class CacheFactory
    {
        //设置超时时间 Min
        const int EXPIRETIME =1;

        private CacheFactory() { }
        private static readonly object _lock = new object();
        private static ICacheRule _instance = null;
        private static readonly CacheFlag _cacheFlag =CacheFlag.MemoryCache;

        public static ICacheRule GetInstance()
        {
            #region
            if (_cacheFlag == CacheFlag.MemoryCache)
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new MemoryCache(EXPIRETIME);
                        }
                    }
                }
            }
            #endregion

            #region
            if (_cacheFlag == CacheFlag.FileCache)
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new FileCache(EXPIRETIME);
                        }
                    }
                }
            }
            #endregion

            return _instance;
        }
    }
}
