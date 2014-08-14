using DistributedCache.ServiceContract;
using DistributedCache.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;

namespace DistributedCache.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(DistributedCache.Services.NetCacheService));
            try
            {
                host.Open();
                Console.WriteLine("NetCacheService Service Started");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                if (ex.InnerException != null)
                {
                    Console.WriteLine("\n" + ex.InnerException.Message);
                }
            }
            finally
            {
                host.Close();
            }
            Console.ReadKey();
        }
    }
}
