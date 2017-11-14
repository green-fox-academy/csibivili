using Microsoft.EntityFrameworkCore;
using ProjectMeasurement.Controllers;
using ProjectMeasurement.Entities;
using ProjectMeasurement.Repository;
using ProjectMeasurement.Services;
using System.Threading.Tasks;
using Xunit;

namespace ProjectMeasurementTest
{
    public class UserShould
    {
        private DbContextOptionsBuilder<ProjectMeasurementContext> optionsBuilder;
        private HomeController homeController;

        public UserShould()
        {
            optionsBuilder = new DbContextOptionsBuilder<ProjectMeasurementContext>();
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CustomProject2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");
        }

        [Fact]
        public async Task AddUser()
        {
            using (var projectMeasurementContext = new ProjectMeasurementContext(optionsBuilder.Options))
            {
                projectMeasurementContext.Database.EnsureCreated();
                homeController = new HomeController(new UserService(new UserRepository(projectMeasurementContext)));
                homeController.AddUser("user@email.com");
                Assert.Equal(1, await projectMeasurementContext.ProjectMembers.CountAsync());
            };
        }
    }
}
