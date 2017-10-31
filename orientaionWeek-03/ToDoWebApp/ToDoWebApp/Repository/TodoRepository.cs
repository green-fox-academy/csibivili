using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoWebApp.Entities;
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

        public List<Todo> GetList()
        {
            return Context.Todos.ToList();
        }

        public void AddTodo(Todo todo)
        {
            Context.Todos.Add(todo);
            Context.SaveChanges();
        }
    }
}
