using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiGatewayFramework
{
    internal class methodRouter: Irouter
    {
        private readonly Dictionary<string, string> methodMappings;

        public methodRouter(Dictionary<string, string> methodMappings)
        {
            this.methodMappings = methodMappings;
        }

        public void routeRequest(requestClass request)
        {
            //your logic for handling here
            Console.WriteLine("route request in method router");


        }

    }
}
