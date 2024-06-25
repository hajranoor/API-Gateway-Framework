using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ApiGatewayFramework
{
    internal class pathRouter : Irouter
    {

        private readonly Dictionary<string, List<serviceInstanceClass>> pathMappings;
            private readonly loadBalancerClass loadBalancer;

        public pathRouter(Dictionary<string, List<serviceInstanceClass>> pathMappings, loadBalancerClass loadBalancer)
        {
            this.pathMappings = pathMappings;
            this.loadBalancer = loadBalancer;
        }

        public serviceInstanceClass routeRequest(requestClass request)
        {
            //your logic for handling here

            if (pathMappings.TryGetValue(request.getPath(), out var instances))
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
