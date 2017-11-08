using IAmGroot;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace IntegrationTests
{
    public class GrootTests
    {
        private readonly TestServer Server;
        private readonly HttpClient Client;

        public GrootTests()
        {
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task ReturnOkStatus()
        {
            var response = await Client.GetAsync("/groot?message=shouldbeok");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task ExpectedResponseIAmGroot()
        {
            string test = await Client.GetStringAsync("/groot?message=test");

            Assert.Equal("{\"received\":\"test\",\"translated\":\"I am Groot!\"}", test);
        }

        [Fact]
        public async Task ReturnNotOkStatus()
        {
            var response = await Client.GetAsync("/groot");

            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }
    }
}