using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using RitualReminders.Models;
using RitualReminders.ViewModels;

namespace RitualReminders.Controllers
{
    [Authorize]
    public class TodosController : Controller
    {
        private ApplicationDbContext _context;
        private UserManager<ApplicationUser> manager;

        public TodosController()
        {
            _context = new ApplicationDbContext();
            manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(_context));

        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Todos
        public ViewResult Index()
        {
            var todos = _context.ToDos.Include(t => t.TodoSnooze).ToList();
            return View(todos);
        }


        public ActionResult New()
        {

            var snoozeTypes = _context.TodoSnoozes.ToList();
            var viewModel = new TodoViewModel
            {
                Todo = new Todo(),
                TodoSnoozes = snoozeTypes
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<ActionResult> Save(Todo todo)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new TodoViewModel()
                {
                    Todo = todo,
                    TodoSnoozes = _context.TodoSnoozes.ToList()
                };

                return View("New", viewModel);
            }

            if (todo.ToDoId == 0)
            {
                var currentUser = await manager.FindByIdAsync(User.Identity.GetUserId());

                //var todoInDb = _context.ToDos.Single(t => t.ToDoId == todo.ToDoId);
                /*todoInDb.Title = todo.Title;
                todoInDb.Detail = todo.Detail;
                todoInDb.DueDate = todo.DueDate;*/
                todo.ApplicationUser = currentUser;

                _context.ToDos.Add(todo);
            }
           
            _context.SaveChanges();

            return RedirectToAction("Index", "Todos");
        }


        public ActionResult Details(int id)
        {
            
            var todo = _context.ToDos.SingleOrDefault(t => t.ToDoId == id);

            if (todo == null)
                return HttpNotFound();

            var viewModel = new TodoViewModel
            {
                Todo = todo,
                TodoSnoozes = _context.TodoSnoozes.ToList()
            };

            //return View("CustomerForm", viewModel);
            return View("Details", viewModel);            

        }

    }// end class
}   // end namespace