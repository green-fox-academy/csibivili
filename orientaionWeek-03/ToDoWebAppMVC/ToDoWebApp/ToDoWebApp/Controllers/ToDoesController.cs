using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ToDoWebApp.Data;
using ToDoWebApp.Models;

namespace ToDoWebApp.Controllers
{
    public class ToDoesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ToDoesController(ApplicationDbContext context)
        {
            _context = context;    
        }

        public async Task<IActionResult> Index()
        {
            string currentUserName = User.Identity.Name;
            ApplicationUser currentUser = _context.Users.FirstOrDefault(x => x.UserName == currentUserName);
            return View(await _context.ToDos.Where(x => x.User == currentUser).ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var toDo = await _context.ToDos
                .SingleOrDefaultAsync(m => m.Id == id);
            if (toDo == null)
            {
                return NotFound();
            }

            return View(toDo);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Description,IsDone")] ToDo toDo)
        {
            if (ModelState.IsValid)
            {
                string currentUserName = User.Identity.Name;
                ApplicationUser currentUser = _context.Users.FirstOrDefault(x => x.UserName == currentUserName);
                toDo.User = currentUser;
                _context.Add(toDo);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(toDo);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var toDo = await _context.ToDos.SingleOrDefaultAsync(m => m.Id == id);
            if (toDo == null)
            {
                return NotFound();
            }
            return View(toDo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Description,IsDone")] ToDo toDo)
        {
            if (id != toDo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(toDo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ToDoExists(toDo.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(toDo);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var toDo = await _context.ToDos
                .SingleOrDefaultAsync(m => m.Id == id);
            if (toDo == null)
            {
                return NotFound();
            }

            return View(toDo);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var toDo = await _context.ToDos.SingleOrDefaultAsync(m => m.Id == id);
            _context.ToDos.Remove(toDo);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool ToDoExists(int id)
        {
            return _context.ToDos.Any(e => e.Id == id);
        }
    }
}
