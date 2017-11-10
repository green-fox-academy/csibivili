using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using ToDoWebApp;
using Xunit;

namespace IntegrationTests
{
    public class GrootTests
    {
        [Fact]
        public async Task ReturnOkStatus()
        {
            var optionsBuilder = new DbContextOptionsBuilder<TodoContext>();
            optionsBuilder.UseSqlServer("Data Source=blog.db");

            using (var context = new TodoContext(optionsBuilder.Options))
            {
                // do stuff
            }
        }
    }
}