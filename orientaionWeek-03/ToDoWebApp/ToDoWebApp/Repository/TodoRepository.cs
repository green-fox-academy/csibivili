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

        public List<Todo> NotDoneList()
        {
            return Context.Todos.Where(a => a.IsDone==false).ToList();
        }

        public void AddTodo(Todo todo)
        {
            Context.Todos.Add(todo);
            Context.SaveChanges();
        }

        public void DeleteTodo(int id)
        {
            var todo = Context.Todos.FirstOrDefault(t => t.Id == id);
            Context.Todos.Remove(todo);
            Context.SaveChanges();
        }

        public Todo AllProperty(int id)
        {
            return Context.Todos.FirstOrDefault(t => t.Id == id);
        }

        public void UpdateTodo(Todo todo)
        {
            Context.Todos.Update(todo);
            Context.SaveChanges();
        }
    }
}
