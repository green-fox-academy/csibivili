using ProjectMeasurement.Entities;
using ProjectMeasurement.Models;

namespace ProjectMeasurement.Repository
{
    public class ProjectRepository
    {
        public static readonly string No_Assigned_Project = "You do not have assigned project";

        private MeasurementContext MeasurementContext;

        public ProjectRepository(MeasurementContext measurementContext)
        {
            MeasurementContext = measurementContext;
            CreateDefaultProject();
        }

        public void CreateDefaultProject()
        {
            if (MeasurementContext.Projects.Find(No_Assigned_Project) == null)
            {
                MeasurementContext.Projects.Add(new Project() { ProjectName = No_Assigned_Project });
            }
        }

        public void AddProject(string projectName)
        {
            MeasurementContext.Projects.Add(new Project() { ProjectName = projectName });
            MeasurementContext.SaveChanges();
        }

        public void DeleteProject(string projectName)
        {
            //later when people will be assigned to projects I might have change this code
            MeasurementContext.Projects.Remove(MeasurementContext.Projects.Find(projectName));
            MeasurementContext.SaveChanges();
        }
    }
}
