using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console.RemoteTest
{
    class Program
    {
        static void Main(string[] args)
        {
            DistributedCacheService.INetCacheService service = new DistributedCacheService.NetCacheServiceClient();
            while (true)
            {
                object obj = service.GetCache("zhazha");
                if (null != obj)
                {
                    System.Console.WriteLine("--time:{0}--", DateTime.Now.ToString());
                    System.Console.WriteLine(" read form {0} zhazha: " + obj.ToString(), "172.16.15.205");
                }
                if (null == obj)
                {
                    System.Console.WriteLine("--time:{0}--", DateTime.Now.ToString());
                    System.Console.WriteLine(" read form {0} zhazha: obj is null", "172.16.15.205");
                    break;
                }

                System.Threading.Thread.Sleep(1000 * 5);
            }

            System.Console.Read();
        }
    }
}
