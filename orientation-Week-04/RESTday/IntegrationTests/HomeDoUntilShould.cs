using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using RESTday;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace IntegrationTests
{
    public class RestDoUntilShould
    {
        private readonly TestServer Server;
        private readonly HttpClient Client;

        public RestDoUntilShould()
        {
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task ReturnOkStatus()
        {
            var response = await Client.GetAsync("rest/dountil/hellaaoouu");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}