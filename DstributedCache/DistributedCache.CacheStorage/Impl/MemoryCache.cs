using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace DistributedCache.CacheStorage
{
    public class MemoryCache : ICacheRule
    {
        private int EXPIRETIME = 0;

        public MemoryCache(int _expireTime)
        {
            this.EXPIRETIME = _expireTime;
        }

        public string AppendCache(string key, object value)
        {
            try
            {
                HttpRuntime.Cache.Insert(key, value, null, DateTime.UtcNow.AddMinutes(EXPIRETIME), TimeSpan.Zero);
                System.Console.WriteLine("{0} ： localhost write cache succeed!", DateTime.Now.ToString());

                string[] hostIP = ChannelFactory.GetHost();
                object obj = null;
                CacheService02.INetCacheService service = null;
                for (int i = 0; i < hostIP.Length; i++)
                {
                    service = ChannelFactory.CreateWCFServiceByURI<CacheService02.INetCacheService>(hostIP[i]);
                    obj = service.GetCache(key);
                    if (null == obj)
                    {
                        service.AppendCache(key, value);
                        System.Console.WriteLine("{0} ： {1} write cache succeed!", DateTime.Now.ToString(), hostIP[i]);
                    }
                }

                System.Console.WriteLine("{0} ： write cache succeed!", DateTime.Now.ToString());
                return "Success";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string RemoveCache(string key)
        {
            throw new NotImplementedException();
        }

        public string ClearCahe()
        {
            throw new NotImplementedException();
        }

        public object GetCache(string key)
        {
            try
            {
                object objResult = HttpRuntime.Cache.Get(key);
                System.Console.WriteLine("{0} : read cache succeed!",DateTime.Now.ToString());
                return objResult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
