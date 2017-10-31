using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoWebApp.Models;

namespace ToDoWebApp.Repository
{
    public class TodoRepository
    {
        Context Context;
        
        public TodoRepository(Context context)
        {
            Context = context;
        }

        public void AddTodo(Todo todo)
        {
            Context.Todos.Add(todo);
            Context.SaveChanges();
        }
    }
}
