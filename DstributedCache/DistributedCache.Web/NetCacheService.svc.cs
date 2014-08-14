using DistributedCache.CacheStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DistributedCache.Web
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "NetCacheService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select NetCacheService.svc or NetCacheService.svc.cs at the Solution Explorer and start debugging.
    public class NetCacheService : INetCacheService
    {
        public String AppendCache(string key, object value)
        {
            return CacheFactory.GetInstance().AppendCache(key, value);
        }
    }
}
