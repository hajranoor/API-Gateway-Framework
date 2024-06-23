using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiGatewayFramework
{
    internal class routeFactory
    {
        public static Irouter GetRouter(string routeType, Dictionary<string, string> mappings)
        {
            switch (routeType)
            {
                case "path":
                    return new pathRouter(mappings);
                case "method":
                    return new methodRouter(mappings);
                default:
                    throw new ArgumentException("Invalid Routing Type");
            }
        }
    }
}
