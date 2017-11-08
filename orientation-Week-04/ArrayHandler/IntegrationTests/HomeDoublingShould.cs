//using Microsoft.AspNetCore.Hosting;
//using Microsoft.AspNetCore.TestHost;
//using ArrayHandler;
//using System.Net;
//using System.Net.Http;
//using System.Threading.Tasks;
//using Xunit;

//namespace IntegrationTests
//{
//    public class HomeOperationsShould
//    {
//        private readonly TestServer Server;
//        private readonly HttpClient Client;

//        public HomeOperationsShould()
//        {
//            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
//            Client = Server.CreateClient();
//        }

//        [Fact]
//        public async Task ReturnOkStatus()
//        {
//            var response = await Client.GetAsync("/home/arrays");

//            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
//        }
//    }
//}