using System;
using ProjectMeasurement.Entities;
using ProjectMeasurement.Models;

namespace ProjectMeasurement.Repository
{
    public class UserRepository
    {
        public static readonly string Default_User = "DefaultUser@email.com";

        private MeasurementContext MeasurementContext;

        public UserRepository(MeasurementContext measurementContext)
        {
            MeasurementContext = measurementContext;
            CreateDefaultUser();
        }

        public void CreateDefaultUser()
        {
            if (MeasurementContext.ProjectMembers.Find(Default_User) == null)
            {
                MeasurementContext.ProjectMembers.Add(new ProjectMember() { EmailAddress = Default_User });
            }
        }

        public void AddNewUser(string emailAddress)
        {
            MeasurementContext.ProjectMembers.Add(new ProjectMember() { EmailAddress = emailAddress, Project = MeasurementContext.Projects.Find(ProjectRepository.No_Assigned_Project)});
            MeasurementContext.SaveChanges();
        }

        public bool AuthenticateUser(string emailAddress)
        {
            return MeasurementContext.ProjectMembers.Find(emailAddress) != null;
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

        public void AddNewTask(string taskName, string projectName)
        {
            MeasurementContext.ProjectTasks.Add(new ProjectTask()
            {
                TaskName = taskName,
                ProjectMember = MeasurementContext.ProjectMembers.Find(Default_User),
                Project = MeasurementContext.Projects.Find(projectName)
            });
            MeasurementContext.SaveChanges();
        }
    }
}