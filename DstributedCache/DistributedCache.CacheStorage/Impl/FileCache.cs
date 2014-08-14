using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DistributedCache.CacheStorage
{
    public class FileCache : ICacheRule
    {
        private int EXPIRETIME = 0;

        public FileCache(int _expireTime)
        {
            this.EXPIRETIME = _expireTime;
        }

        public string AppendCache(string key, object value)
        {
            throw new NotImplementedException();
        }

        public string RemoveCache(string key)
        {
            throw new NotImplementedException();
        }

        public string ClearCahe()
        {
            throw new NotImplementedException();
        }

        object ICacheRule.GetCache(string key)
        {
            throw new NotImplementedException();
        }
    }
}
