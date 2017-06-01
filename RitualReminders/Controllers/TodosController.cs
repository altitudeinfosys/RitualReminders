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
            //var todos = _context.ToDos.OrderBy(t => t.CreateDate).Include(t => t.TodoSnooze).ToList();
            //return View(todos);
            return View();
        }


        public ActionResult New()
        {

            var snoozeTypes = _context.TodoSnoozes.ToList();
            var viewModel = new TodoViewModel
            {
                Todo = new Todo(),
                TodoSnoozes = snoozeTypes
            };

            return View("TodoForm", viewModel);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Save(Todo todo)
        {
            var currentUser = await manager.FindByIdAsync(User.Identity.GetUserId());

            if (!ModelState.IsValid)
            {
                var snoozeTypes = _context.TodoSnoozes.ToList();
                var viewModel = new TodoViewModel
                {
                    Todo = new Todo(),
                    TodoSnoozes = snoozeTypes
                };

                return View("TodoForm", viewModel);

            }

            if (todo.ToDoId == 0)
            {
                
                todo.CreateDate = DateTime.Now;
                todo.CreateUser = currentUser.UserName;
                todo.ApplicationUser = currentUser;

                _context.ToDos.Add(todo); // to add to the Todos Collection 
            }
            else
            {
                var todoInDb = _context.ToDos.Single(t => t.ToDoId == todo.ToDoId);
                todoInDb.Title = todo.Title;
                todoInDb.Detail = todo.Detail;
                todoInDb.Completed = todo.Completed;
                todoInDb.DueDate = todo.DueDate;
                todoInDb.TodoSnoozeId = todo.TodoSnoozeId;
                todoInDb.UpdateDate = DateTime.Today;
                todoInDb.UpdateUser = currentUser.UserName;

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
            return View("TodoForm", viewModel);            

        }

    }// end class
}   // end namespace