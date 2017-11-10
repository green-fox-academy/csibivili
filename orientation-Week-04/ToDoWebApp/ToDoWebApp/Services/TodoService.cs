using ToDoWebApp.Models;
using ToDoWebApp.Repository;

namespace ToDoWebApp.Services
{
    public class TodoService
    {
        private TodoRepository TodoRepository;

        public TodoService(TodoRepository todoRepository)
        {
            TodoRepository = todoRepository;
        }

        public User UserWithList(int id)
        {
            return TodoRepository.UserWithList(id);
        }

        public void AddTodo(string title, int id)
        {
            TodoRepository.AddTodo(title, id);
        }
    }
}
