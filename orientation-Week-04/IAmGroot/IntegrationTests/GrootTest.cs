using IAmGroot;
using IAmGroot.Controllers.Home;
using IAmGroot.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
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

        [Fact]
        public async Task ExpectedErrorIAmGroot()
        {
            var controller = new HomeController();

            var result = controller.Groot(message: null);

            Assert.IsType<NotFoundObjectResult>(result);
        }

        [Fact]
        public async Task ReturnOkStatusYondu()
        {
            var response = await Client.GetAsync("/yondu?distance=100.0&time=10.0");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task ExpectedResponseYondu()
        {
            var controller = new HomeController();

            //var result = controller.Yondu(distance: 100.0, time: 10.0);

            string response = await Client.GetStringAsync("/yondu?distance=100.0&time=10.0");

            Assert.Equal(0, new Yondu() { Distance = 100.0, Time = 10.0 }.CompareTo(response));
        }

        //[Fact]
        //public async Task ReturnNotOkStatus()
        //{
        //    var response = await Client.GetAsync("/groot");

        //    Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        //}

        //[Fact]
        //public async Task ExpectedErrorIAmGroot()
        //{
        //    var controller = new HomeController();

        //    var result = controller.Groot(message: null);

        //    Assert.IsType<NotFoundObjectResult>(result);
        //}
    }
}