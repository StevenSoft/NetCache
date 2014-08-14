using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DistributedCache.CacheStorage
{
    public interface ICacheRule
    {
        String AppendCache(String key,Object value);

        String RemoveCache(String key);

        String ClearCahe();

        Object GetCache(string key);
    }
}
