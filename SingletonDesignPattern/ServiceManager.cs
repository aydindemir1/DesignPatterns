using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public class ServiceManager
    {
        private static ServiceManager instance = null;
        private static readonly object padlock = new object();
        private Dictionary<string, string> services;

        private ServiceManager()
        {
            services = new Dictionary<string, string>();
        }

        public static ServiceManager Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new ServiceManager();
                    }
                    return instance;
                }
            }
        }

        public void RegisterService(string serviceName, string serviceUrl)
        {
            if (!services.ContainsKey(serviceName))
            {
                services[serviceName] = serviceUrl;
            }
        }

        public string GetServiceUrl(string serviceName)
        {
            return services.ContainsKey(serviceName) ? services[serviceName] : null;
        }
    }

}
