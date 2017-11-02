using Microsoft.AspNetCore.Mvc;
using ToDoWebApp.Models;
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

        [HttpPost]
        public IActionResult LoginHandler(User userFromForm)
        {
            int id = TodoRepository.LogIn(userFromForm);
            return RedirectToAction("List", id);
        }

        [Route("/todo/list")]
        [HttpGet]
        public IActionResult List(bool IsActive, bool IsUrgent, int id)
        {
            if (IsActive && IsUrgent)
            {
                return View(TodoRepository.UrgentAndActiveList());
            }
            else if (IsActive)
            {
                return View(TodoRepository.NotDoneList());
            }
            else if (IsUrgent)
            {
                return View(TodoRepository.UrgentList());
            }
            else 
            {
                return View(TodoRepository.GetList(id));
            }           
        }

        [Route("/todo/form")]
        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }

        [Route("/todo/add")]
        [HttpPost]
        public IActionResult Add(Todo todo)
        {
            TodoRepository.AddTodo(todo);
            return RedirectToAction("List");
        }

        [Route("/{id}/delete")]
        [HttpPost]
        public IActionResult Delete(int id)
        {
            TodoRepository.DeleteTodo(id);
            return RedirectToAction("List");
        }

        [Route("/todo/{id}/update")]
        [HttpPost]
        public IActionResult Update(int id)
        {
            var todo = TodoRepository.AllProperty(id);
            return View(todo);
        }

        [Route("/{id}/edit")]
        [HttpPost]
        public IActionResult Edit(Todo todo)
        {
            TodoRepository.UpdateTodo(todo);
            return RedirectToAction("List");
        }

        [Route("/{id}/back")]
        [HttpGet]
        public IActionResult Back()
        {
            return RedirectToAction("List");
        }
    }
}
