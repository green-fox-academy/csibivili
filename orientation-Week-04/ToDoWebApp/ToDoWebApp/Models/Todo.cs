namespace ToDoWebApp.Models
{
    public partial class Todo
    {
        public int? TodoId { get; set; }
        public string Title { get; set; }

        public virtual User User { get; set; }
    }
}
