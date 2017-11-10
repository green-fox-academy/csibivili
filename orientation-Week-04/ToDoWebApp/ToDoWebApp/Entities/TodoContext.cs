using Microsoft.EntityFrameworkCore;
using ToDoWebApp.Models;

namespace ToDoWebApp
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Todo> Todos { get; set; }
    }
}