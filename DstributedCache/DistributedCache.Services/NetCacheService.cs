using DistributedCache.ServiceContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using DistributedCache.CacheStorage;

namespace DistributedCache.Services
{
    public class NetCacheService : INetCacheService
    {
        /// <summary>
        /// 将新数据放入缓存
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public String AppendCache(string key, object value)
        {
            return CacheFactory.GetInstance().AppendCache(key, value);
        }

        /// <summary>
        /// 移除指定缓存值
        /// </summary>
        /// <param name="key"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public String RemoveCache(string key)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 清空指定host上的所有缓存
        /// </summary>
        /// <param name="key"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public String ClearCache()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 获取指定缓存
        /// </summary>
        /// <param name="key"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public Object GetCache(string key)
        {
            return CacheFactory.GetInstance().GetCache(key);
        }
    }
}
