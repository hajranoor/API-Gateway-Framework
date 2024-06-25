using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiGatewayFramework
{
    internal class serviceInstanceClass
    {
        private string Id;
        private int activeConnections;

        public serviceInstanceClass(string id)
        {

        this.Id = id; }

        public void setID(string id)
        {
            this.Id = id;
        }

        public void setActiveConnections(int activeConnections)
        {
            this.activeConnections = activeConnections;
        }

        public int getActiveConnections()
        { 
            return this.activeConnections;
        }

        public string getId()
        {

        return this.Id; 
        }

        public async void handleRequest(requestClass request)
        {
            activeConnections++;
            Console.WriteLine($"Service {Id} is handling request {request.getId}");   
            await  Task.Delay(1000);
            activeConnections--;
            Console.WriteLine($"Service {Id} has completed request {request.getId}");  




        }

    }
}
