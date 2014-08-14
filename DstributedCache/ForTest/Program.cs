using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForTest
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Server start...");

            CacheService.INetCacheService service =new CacheService.NetCacheServiceClient();

            service.AppendCache("meimei", DateTime.Now.ToString());

            System.Console.Read();
        }
    }
}
