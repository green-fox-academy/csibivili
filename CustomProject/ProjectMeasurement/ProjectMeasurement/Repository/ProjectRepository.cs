using ProjectMeasurement.Entities;
using ProjectMeasurement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
    }
}
