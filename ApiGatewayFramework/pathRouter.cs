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

        private readonly Dictionary<string, string> pathMappings;

        public pathRouter(Dictionary<string, string> pathMappings)
        {
            this.pathMappings = pathMappings;
        }

        public void routeRequest(requestClass request)
        {
            //your logic for handling here
            Console.WriteLine("route request in path router");
        }
    }
}
