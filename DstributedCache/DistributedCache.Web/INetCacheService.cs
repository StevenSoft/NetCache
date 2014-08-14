using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DistributedCache.Web
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "INetCacheService" in both code and config file together.
    [ServiceContract]
    public interface INetCacheService
    {
        [OperationContract]
        String AppendCache(String key, Object value);
    }
}
