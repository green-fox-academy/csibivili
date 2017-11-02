using System.Collections.Generic;

namespace ToDoWebApp.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }

        public ICollection<Todo> Todos { get; set; }

        public void AddTodo(string todo)
        {
            this.Todos.Add(new Todo() { Title=todo});
        }
    }
}
