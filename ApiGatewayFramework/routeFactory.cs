using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiGatewayFramework
{
    internal class routeFactory
    {
        public static Irouter GetRouter(string routeType, Dictionary<string, List<serviceInstanceClass>> mappings, loadBalancerClass loadBalancer)
        {
            switch (routeType)
            {
                case "path":
                    return new pathRouter(mappings, loadBalancer);
                case "method":
                    return new methodRouter(mappings, loadBalancer);
                default:
                    throw new ArgumentException("Invalid Routing Type");
            }
        }
    }
}
