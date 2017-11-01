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
        public IActionResult List(bool IsActive)
        {
            if (IsActive)
            {
                return View(TodoRepository.NotDoneList());
            }
            return View(TodoRepository.GetList());
        }

        [Route("/todo/form")]
        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }

        [Route("/todo/add")]
        [HttpPost]
        public IActionResult Add(string title)
        {
            TodoRepository.AddTodo(title);
            return RedirectToAction("List");
        }

        [Route("/{id}/delete")]
        [HttpPost]
        public IActionResult Delete(int id)
        {
            TodoRepository.DeleteTodo(id);
            return RedirectToAction("List");
        }
    }
}
