using ProjectMeasurement.Entities;
using ProjectMeasurement.Models;

namespace ProjectMeasurement.Repository
{
    public class ProjectRepository
    {
        private MeasurementContext MeasurementContext;

        public ProjectRepository(MeasurementContext measurementContext)
        {
            MeasurementContext = measurementContext;
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
