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

            var pathMappings = new Dictionary<string, string>
            {
                { "/api/v1/resource1", "http://service1/resource1" },
                { "/api/v1/resource2", "http://service2/resource2" }

            };

            var methodMappings = new Dictionary<string, string>
            {
                { "GET", "http://getService" },
                { "POST", "http://postService" }
            };



            Irouter pathRouter = routeFactory.GetRouter("path", pathMappings);
            requestClass request = new requestClass();
            request.setPath("/api/v1/resource1");
            request.setMethod("GET");
            pathRouter.routeRequest(request);


            Irouter methodRouter = routeFactory.GetRouter("method", methodMappings);
            requestClass Methodrequest = new requestClass();
            Methodrequest.setPath("/api/v1/resource3");
            Methodrequest.setMethod("POST");
            pathRouter.routeRequest(Methodrequest);

        }
    }
}
