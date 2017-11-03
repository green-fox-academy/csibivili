using System.Collections.Generic;


namespace ToDoWebApp.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }

        public ICollection<Todo> Todos { get; set; }
    }

}
