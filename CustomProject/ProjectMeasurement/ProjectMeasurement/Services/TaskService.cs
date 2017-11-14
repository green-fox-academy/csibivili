using ProjectMeasurement.Repository;

namespace ProjectMeasurement.Services
{
    public class TaskService
    {
        private TaskRepository TaskRepository;

        public TaskService(TaskRepository taskRepository)
        {
            TaskRepository = taskRepository;
        }
    }
}
