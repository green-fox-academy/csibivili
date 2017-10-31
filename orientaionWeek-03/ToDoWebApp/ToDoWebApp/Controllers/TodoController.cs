using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoWebApp.Repository;

namespace ToDoWebApp.Controllers
{
    [Route("/Todo")]
    public class TodoController : Controller
    {
        TodoRepository TodoRepository;

        public TodoController(TodoRepository todoRepository)
        {
            TodoRepository = todoRepository;
        }

        [Route("")]
        [HttpGet]
        public IActionResult List()
        {
            TodoRepository.AddTodo(new Models.Todo() { Title = "move forward", IsDone = false, IsUrgent = true });
            TodoRepository.AddTodo(new Models.Todo() { Title = "add more elements", IsDone = true, IsUrgent = false });
            return View(TodoRepository.GetList());
        }
    }
}
