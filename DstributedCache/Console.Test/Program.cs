using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            DistributedCacheService.INetCacheService service = new DistributedCacheService.NetCacheServiceClient();
            string value = "test string";
            service.AppendCache("zhazha", value);
            System.Console.WriteLine("set 'zhazha' value : [{0}] to {1} succeed!", value, "172.16.15.121");
            System.Console.Read();
        }
    }
}
