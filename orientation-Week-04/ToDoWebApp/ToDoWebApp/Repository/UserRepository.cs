using System.Linq;
using ToDoWebApp.Models;

namespace ToDoWebApp.Repository
{
    public class UserRepository
    {
        TodoContext TodoContext;

        public UserRepository(TodoContext todoContext)
        {
            TodoContext = todoContext;
        }

        public bool CheckUserExist(string name)
        {
            var user = TodoContext.Users.FirstOrDefault(u => u.UserName.Equals(name));
            return user != null;
        }

        public void AddUser(string userName)
        {
            TodoContext.Users.Add(new User() { UserName = userName });

            TodoContext.SaveChanges();
        }

        public User UserInfo(string userName)
        {
            return TodoContext.Users.FirstOrDefault(u => u.UserName == userName);
        }
    }
}
