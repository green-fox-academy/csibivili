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
        private readonly DbContextOptionsBuilder<MeasurementContext> optionsBuilder;

        public UserShould()
        {
            optionsBuilder = new DbContextOptionsBuilder<MeasurementContext>();
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CustomProject3;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");
        }

        [Fact]
        public async Task AddUserAndDeleteUser()
        {
            using (var projectMeasurementContext = new MeasurementContext(optionsBuilder.Options))
            {
                projectMeasurementContext.Database.EnsureCreated();
                var homeController = new AdminController(new UserService(new UserRepository(projectMeasurementContext)));
                homeController.AddUser("user@email.com");
                Assert.Equal(1, await projectMeasurementContext.ProjectMembers.CountAsync());
                homeController.DeleteUser("user@email.com");
                Assert.Equal(0, await projectMeasurementContext.ProjectMembers.CountAsync());
            };
        }
    }
}
