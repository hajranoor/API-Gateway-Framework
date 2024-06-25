using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiGatewayFramework
{
    internal class methodRouter: Irouter
    {
        private readonly Dictionary<string, List<serviceInstanceClass>> methodMappings;
        private readonly loadBalancerClass loadBalancer;


        public methodRouter(Dictionary<string, List<serviceInstanceClass>> methodMappings, loadBalancerClass loadBalancer)
        {
            this.methodMappings = methodMappings;
            this.loadBalancer = loadBalancer;
        }


        public serviceInstanceClass routeRequest(requestClass request)
        {
            //your logic for handling here
            Console.WriteLine("route request in method router");

            if (methodMappings.TryGetValue(request.getMethod(), out var instances))
            { 
                return loadBalancer.GetInstance(instances);
            }
            else
            {
                return null;
            }



        }

    }
}
