namespace ApiGatewayFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            var pathMappings = new Dictionary<string, List<serviceInstanceClass>>
        {
            { "/api/v1/resource1", new List<serviceInstanceClass> { new serviceInstanceClass("Instance1"), new serviceInstanceClass("Instance2") } },
            { "/api/v1/resource2", new List<serviceInstanceClass> { new serviceInstanceClass("Instance3"), new serviceInstanceClass("Instance4") } }
        };

            var methodMappings = new Dictionary<string, List<serviceInstanceClass>>
        {
            { "GET", new List<serviceInstanceClass> { new serviceInstanceClass("Instance1"), new serviceInstanceClass("Instance3") } },
            { "POST", new List<serviceInstanceClass> { new serviceInstanceClass("Instance2"), new serviceInstanceClass("Instance4") } }
        };


            var loadBalancer = new loadBalancerClass();



            //Irouter pathRouter = routeFactory.GetRouter("path", pathMappings);
            //requestClass request = new requestClass();
            //request.setPath("/api/v1/resource1");
            //request.setMethod("GET");
            //pathRouter.routeRequest(request);


            //Irouter methodRouter = routeFactory.GetRouter("method", methodMappings);
            //requestClass Methodrequest = new requestClass();
            //Methodrequest.setPath("/api/v1/resource3");
            //Methodrequest.setMethod("POST");
            //pathRouter.routeRequest(Methodrequest);

            string routerType = "path";

            Irouter router = routeFactory.GetRouter(routerType, routerType == "path" ? pathMappings : methodMappings, loadBalancer);

            var requests = new List<requestClass>();

            var request1 = new requestClass("Request1");
            request1.setPath("/api/v1/resource1");
            request1.setMethod("GET");

            var request2 = new requestClass("Request2");
            request2.setPath("/api/v1/resource2");
            request2.setMethod("POST");

            var request3 = new requestClass("Request3");
            request3.setPath("/api/v1/resource1");
            request3.setMethod("POST");

            var request4 = new requestClass("Request4");
            request4.setPath("/api/v1/resource3");
            request4.setMethod("GET");

            requests.Add(request1);
            requests.Add(request2);
            requests.Add(request3);
            requests.Add(request4);

            foreach (var request in requests)
            {
                var instance = router.routeRequest(request);
                instance?.handleRequest(request);
            }










        }
    }
}
