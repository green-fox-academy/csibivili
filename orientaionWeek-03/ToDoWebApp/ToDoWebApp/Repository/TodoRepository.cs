using System.Collections.Generic;
using System.Linq;
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

        public void LogIn(User user)
        {
            Context.Users.Add(user);
            Context.SaveChanges();
            //return Context.Users.FirstOrDefault(a => a.Name == user.Name).UserId;
        }

        public List<Todo> GetList(int id)
        {
            return Context.Todos.Where(a => id == a.UserId).OrderBy(a => a.Id).ToList();
        }

        public List<Todo> NotDoneList()
        {
            return Context.Todos.Where(a => a.IsDone==false).OrderBy(a => a.Id).ToList();
        }

        public List<Todo> UrgentList()
        {
            return Context.Todos.Where(a => a.IsUrgent == true).OrderBy(a => a.Id).ToList();
        }

        public List<Todo> UrgentAndActiveList()
        {
            return Context.Todos.Where(a => a.IsUrgent == true && a.IsDone == false).ToList();
        }

        public void AddTodo(string title, int id)
        {
            Context.Todos.Add(new Todo() { Title = title, UserId = id });
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
