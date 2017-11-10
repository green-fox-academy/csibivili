using System.Linq;
using ToDoWebApp.Models;

namespace ToDoWebApp.Repository
{
    public class TodoRepository
    {
        TodoContext TodoContext;

        public TodoRepository(TodoContext todoContext)
        {
            TodoContext = todoContext;
        }

        public void AddTodo(string title, int id)
        {
            TodoContext.Todos.Add(new Todo() { Title = title, User = TodoContext.Users.FirstOrDefault(u => u.UserId == id)});
            TodoContext.SaveChanges();
        }

        public User UserWithList(int id)
        {
            var user = TodoContext.Users.FirstOrDefault(u => u.UserId == id);
            user.Todos = TodoContext.Todos
                .Where(a => a.User.UserId == id)
                .OrderBy(a => a.TodoId).ToList();
            return user;               
        }
    }
}
