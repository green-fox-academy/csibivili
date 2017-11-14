using ProjectMeasurement.Models;
using ProjectMeasurement.Repository;

namespace ProjectMeasurement.Services
{
    public class UserService
    {
        private UserRepository UserRepository;

        public UserService(UserRepository userRepository)
        {
            UserRepository = userRepository;
        }

        public void AddNewUser(string emailAddress)
        {
            UserRepository.AddNewUser(emailAddress);
        }

        public void DeleteUser(string emailAddress)
        {
            UserRepository.DeleteUser(emailAddress);
        }

        public void AssignUser(string emailAddress, string projectName)
        {
            UserRepository.AssignUser(emailAddress, projectName);
        }

        public void RemoveUserFromProject(string emailAddress, string projectName)
        {
            UserRepository.RemoveUserFromProject(emailAddress, projectName);
        }

        public ProjectMember UserInfo(string emailAddress)
        {
            return UserRepository.UserInfo(emailAddress);
        }
    }
}
