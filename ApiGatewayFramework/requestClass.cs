using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiGatewayFramework
{
    internal class requestClass
    {
        private string path;
        private string method;

        public string getPath()
        {
            return this.path;
        }

        public void setPath(string Path)
        {
            this.path = Path;
        }

        public string getMethod()
        {
            return this.method;
        }

        public void setMethod(string Method)
        {
            this.method = Method;
        }

    }
}
