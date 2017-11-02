﻿namespace ToDoWebApp.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsUrgent { get; set; }
        public bool IsDone { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
    }
}
