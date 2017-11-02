using Microsoft.AspNetCore.Mvc;
using ToDoWebApp.Models;
using ToDoWebApp.Repository;

namespace ToDoWebApp.Controllers
{
    [Route("/Todo")]
    public class TodoController : Controller
    {
        TodoRepository TodoRepository;
        User user;

        public TodoController(User user, TodoRepository todoRepository)
        {
            TodoRepository = todoRepository;
            this.user = user;
        }

        [HttpPost]
        public IActionResult LoginHandler(User userFromForm)
        {
            user = userFromForm;
            TodoRepository.LogIn(userFromForm);
            return RedirectToAction("List");
        }

        [Route("/todo/list")]
        [HttpGet]
        public IActionResult List(bool IsActive, bool IsUrgent)
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
                return View(TodoRepository.GetList(user.UserId));
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
        public IActionResult Add(string title)
        {
            TodoRepository.AddTodo(title, user.UserId);
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
