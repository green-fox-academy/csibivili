using Microsoft.EntityFrameworkCore;
using ProjectMeasurement.Controllers;
using ProjectMeasurement.Entities;
using ProjectMeasurement.Repository;
using ProjectMeasurement.Services;
using System.Threading.Tasks;
using Xunit;

namespace ProjectMeasurementTest
{
    public class AdminShould
    {
        private readonly DbContextOptionsBuilder<MeasurementContext> optionsBuilder;

        public AdminShould()
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
                var adminController = new AdminController(new UserService(new UserRepository(projectMeasurementContext)));
                adminController.AddUser("user@email.com");
                Assert.Equal(2, await projectMeasurementContext.ProjectMembers.CountAsync());
                adminController.DeleteUser("user@email.com");
                Assert.Equal(1, await projectMeasurementContext.ProjectMembers.CountAsync());
            };
        }

        [Fact]
        public async Task AddProject()
        {
            using (var projectMeasurementContext = new MeasurementContext(optionsBuilder.Options))
            {
                projectMeasurementContext.Database.EnsureCreated();
                var adminController = new AdminController(new ProjectService(new ProjectRepository(projectMeasurementContext)));
                adminController.AddProject("Test Project");
                Assert.Equal(2, await projectMeasurementContext.Projects.CountAsync());
                adminController.DeleteProject("Test Project");
                Assert.Equal(1, await projectMeasurementContext.Projects.CountAsync());
            };
        }
    }
}

