using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiGatewayFramework
{
    internal class loadBalancerClass
    {
        private int roundRobinIndex = 0;
        private Random random = new Random();

        public serviceInstanceClass GetInstance(List<serviceInstanceClass> instances, string algorithm = "round-robin")
        {
            switch (algorithm.ToLower())
            {
                case "round-robin":
                    return GetRoundRobinInstance(instances);
                case "random":
                    return getRandomInstance(instances);
                default:
                    throw new ArgumentException("Invalid Algorithm Specified");

            }
        }

        private serviceInstanceClass GetRoundRobinInstance(List<serviceInstanceClass> instance)
        {
            var Instance = instance[roundRobinIndex];
            roundRobinIndex = (roundRobinIndex + 1) % instance.Count;
            return Instance;
        }

        private serviceInstanceClass getRandomInstance(List<serviceInstanceClass> instance)
        {
            int index = random.Next(instance.Count);
            return instance[index];
        }
    }
}
