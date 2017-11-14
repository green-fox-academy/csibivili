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
                var adminController = new AdminController(new UserService(new UserRepository(projectMeasurementContext)),
                        new ProjectService(new ProjectRepository(projectMeasurementContext)));
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
                var adminController = new AdminController(new UserService(new UserRepository(projectMeasurementContext)),
                        new ProjectService(new ProjectRepository(projectMeasurementContext)));
                adminController.AddProject("TestProject");
                Assert.Equal(3, await projectMeasurementContext.Projects.CountAsync());
                adminController.DeleteProject("TestProject");
                Assert.Equal(2, await projectMeasurementContext.Projects.CountAsync());
            };
        }

        [Fact]
        public void AssignUserToProjectAndRemoveFromProject()
        {
            using (var projectMeasurementContext = new MeasurementContext(optionsBuilder.Options))
            {
                projectMeasurementContext.Database.EnsureCreated();
                var userService = new UserService(new UserRepository(projectMeasurementContext));
                var adminController = new AdminController(userService,new ProjectService(new ProjectRepository(projectMeasurementContext)));
                adminController.RemoveUserFromProject("test@email.com", "Test Project(do not delete)");
                Assert.Equal("no assigned project", userService.UserInfo("test@email.com").Project.ProjectName);
                adminController.AssignUser("test@email.com", "Test Project(do not delete)");
                Assert.Equal("Test Project(do not delete)", userService.UserInfo("test@email.com").Project.ProjectName);
            }
        }
    }
}

