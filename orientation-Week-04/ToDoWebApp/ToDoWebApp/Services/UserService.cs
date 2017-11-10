using ToDoWebApp.Models;
using ToDoWebApp.Repository;

namespace ToDoWebApp.Services
{
    public class UserService
    {
        private UserRepository UserRepository;

        public UserService(UserRepository userRepository)
        {
            UserRepository = userRepository;
        }

        public bool AuthenticateUser(string name)
        {
            return UserRepository.CheckUserExist(name);
        }

        public void AddUser(string name)
        {
            UserRepository.AddUser(name);
        }

        public User UserInfo(string userName)
        {
            return UserRepository.UserInfo(userName);
        }
    }
}
