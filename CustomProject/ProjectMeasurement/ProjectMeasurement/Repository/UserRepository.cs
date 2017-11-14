using ProjectMeasurement.Entities;
using ProjectMeasurement.Models;

namespace ProjectMeasurement.Repository
{
    public class UserRepository
    {
        private ProjectMeasurementContext ProjectMeasurementContext;

        public UserRepository(ProjectMeasurementContext projectMeasurementContext)
        {
            ProjectMeasurementContext = projectMeasurementContext;
        }

        public void AddNewUser(string emailAddress)
        {
            ProjectMeasurementContext.ProjectMembers.Add(new ProjectMember() { EmailAddress = emailAddress });
            ProjectMeasurementContext.SaveChanges();
        }

        public void DeleteUser(long id)
        {
        }
    }
}