using ProjectMeasurement.Entities;
using ProjectMeasurement.Models;

namespace ProjectMeasurement.Repository
{
    public class UserRepository
    {
        private MeasurementContext MeasurementContext;

        public UserRepository(MeasurementContext measurementContext)
        {
            MeasurementContext = measurementContext;
        }

        public void AddNewUser(string emailAddress)
        {
            MeasurementContext.ProjectMembers.Add(new ProjectMember() { EmailAddress = emailAddress, Project = MeasurementContext.Projects.Find(ProjectRepository.No_Assigned_Project)});
            MeasurementContext.SaveChanges();
        }

        public void DeleteUser(string emailAddress)
        {
            //later when people will be assigned to projects I might have change this code
            MeasurementContext.ProjectMembers.Remove(MeasurementContext.ProjectMembers.Find(emailAddress));
            MeasurementContext.SaveChanges();
        }

        public ProjectMember UserInfo(string emailAddress)
        {
            return MeasurementContext.ProjectMembers.Find(emailAddress);
        }

        public void AssignUser(string emailAddress, string projectName)
        {
            if (MeasurementContext.Projects.Find(projectName) != null 
                    && MeasurementContext.ProjectMembers.Find(emailAddress) != null)
            {
                MeasurementContext.Update(
                MeasurementContext.ProjectMembers.Find(emailAddress).Project
                    = MeasurementContext.Projects.Find(projectName));
                MeasurementContext.SaveChanges();
            }
        }

        public void RemoveUserFromProject(string emailAddress, string projectName)
        {
            if (MeasurementContext.Projects.Find(projectName) != null
                    && MeasurementContext.ProjectMembers.Find(emailAddress) != null)
            {
                MeasurementContext.Update(
                MeasurementContext.ProjectMembers.Find(emailAddress).Project
                    = MeasurementContext.Projects.Find(ProjectRepository.No_Assigned_Project));
                MeasurementContext.SaveChanges();
            }
        }
    }
}