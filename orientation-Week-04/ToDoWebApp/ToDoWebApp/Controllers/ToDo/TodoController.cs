using Microsoft.AspNetCore.Mvc;
using ToDoWebApp.Services;

namespace ToDoWebApp.Controllers.ToDo
{
    [Route("/Todo")]
    public class TodoController : Controller
    {
        TodoService TodoService;

        public TodoController(TodoService todoService)
        {
            TodoService = todoService;
        }

        [Route("/todo/{id}/list/")]
        [HttpGet]
        public IActionResult List(int id)
        {
            return View(TodoService.UserWithList(id));
        }

        [Route("/todo/{id}/form")]
        [HttpGet]
        public IActionResult Form(int id)
        {
            return View();
        }

        [Route("/todo/{id}/add")]
        [HttpPost]
        public IActionResult Add(string title, int id)
        {
            TodoService.AddTodo(title, id);
            return RedirectToAction("List");
        }
    }
}
