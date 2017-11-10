using System.Collections.Generic;

namespace ToDoWebApp.Models
{
    public partial class User
    {
        public int? UserId { get; set; }
        public string UserName { get; set; }

        public virtual ICollection<Todo> Todos { get; set; }
    }
}
