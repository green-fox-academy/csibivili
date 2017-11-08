using ArrayHandler.Models;
using IntegrationTests.TestFixtures;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace IntegrationTests.Scenarios.Home
{
    [Collection("BaseCollection")]
    public class DoublingShould
    {
        private TestContext Context;

        public DoublingShould(TestContext context)
        {
            Context = context;
        }

        [Fact]
        public async Task ReturnResult6WhenSum123()
        {
            var operation = new OperationOnNumbers
            {
                What = "sum",
                Numbers = new int[] { 1, 2, 3 }
            };

            var ops = JsonConvert.SerializeObject(operation);

            var stringContent = new StringContent(ops.ToString(), Encoding.UTF8, "application/json");

            var response = await Context.Client.PostAsync("/arrays", stringContent);

            string responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"result\":6}", responseJson);
        }

        [Fact]
        public async Task ReturnResult8WhenMultiply124()
        {
            var operation = new OperationOnNumbers
            {
                What = "multiply",
                Numbers = new int[] { 1, 2, 4 }
            };

            var ops = JsonConvert.SerializeObject(operation);

            var stringContent = new StringContent(ops.ToString(), Encoding.UTF8, "application/json");

            var response = await Context.Client.PostAsync("/arrays", stringContent);

            string responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"result\":8}", responseJson);
        }
    }
}