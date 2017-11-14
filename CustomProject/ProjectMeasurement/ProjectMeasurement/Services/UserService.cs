using ProjectMeasurement.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
    }
}
