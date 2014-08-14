using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace DistributedCache.ServiceContract
{
    [ServiceContract]
    public interface INetCacheService
    {
        [OperationContract]
        String AppendCache(String key, Object value);

        [OperationContract]
        String RemoveCache(String key);

        [OperationContract]
        String ClearCache();

        [OperationContract]
        Object GetCache(String key);
    }
}
