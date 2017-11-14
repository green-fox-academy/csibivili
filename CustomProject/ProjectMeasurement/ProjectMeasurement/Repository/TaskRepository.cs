using ProjectMeasurement.Entities;
using ProjectMeasurement.Models;

namespace ProjectMeasurement.Repository
{
    public class TaskRepository
    {
        private MeasurementContext MeasurementContext;

        public TaskRepository(MeasurementContext measurementContext)
        {
            MeasurementContext = measurementContext;
        }
    }
}
