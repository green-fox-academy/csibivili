using ProjectMeasurement.Entities;
using ProjectMeasurement.Models;

namespace ProjectMeasurement.Repository
{
    public class UserRepository
    {
        private MeasurementContext ProjectMeasurementContext;

        public UserRepository(MeasurementContext projectMeasurementContext)
        {
            ProjectMeasurementContext = projectMeasurementContext;
        }

        public void AddNewUser(string emailAddress)
        {
            ProjectMeasurementContext.ProjectMembers.Add(new ProjectMember() { EmailAddress = emailAddress });
            ProjectMeasurementContext.SaveChanges();
        }

        public void DeleteUser(string emailAddress)
        {
            ProjectMeasurementContext.ProjectMembers
                .Remove(ProjectMeasurementContext.ProjectMembers
                .Find(emailAddress));
            ProjectMeasurementContext.SaveChanges();
        }
    }
}