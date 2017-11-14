using ProjectMeasurement.Repository;

namespace ProjectMeasurement.Services
{
    public class ProjectService
    {
        private ProjectRepository ProjectRepository;

        public ProjectService(ProjectRepository projectRepository)
        {
            ProjectRepository = projectRepository;
        }

        public void AddProject(string projectName)
        {
            ProjectRepository.AddProject(projectName);
        }

        public void DeleteProject(string projectName)
        {
            ProjectRepository.DeleteProject(projectName);
        }
    }
}
