﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiGatewayFramework
{
    internal interface Irouter
    {
        serviceInstanceClass routeRequest(requestClass request);
    }
}
