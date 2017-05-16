using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RitualReminders.Models;
using RitualReminders.ViewModels;

namespace RitualReminders.Controllers
{
    public class TodosController : Controller
    {
        private ApplicationDbContext _context;

        public TodosController()
        {
            _context = new ApplicationDbContext();
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
            var viewModel = new NewTodoViewModel
            {
                Todo = new Todo(),
                TodoSnoozes = snoozeTypes
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Save(Todo todo)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new NewTodoViewModel()
                {
                    Todo = todo,
                    TodoSnoozes = _context.TodoSnoozes.ToList()
                };

                return View("New", viewModel);
            }

            if (todo.ToDoId == 0)
                _context.ToDos.Add(todo);
            else
            {
                var todoInDb = _context.ToDos.Single(t => t.ToDoId == todo.ToDoId);
                todoInDb.Title = todo.Title;
                todoInDb.DueDate = todo.DueDate;
                todoInDb.TodoSnoozeId = todo.TodoSnoozeId;
                todoInDb.Completed = todo.Completed;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Todos");
        }


        public ViewResult Details(int id)

        {
            // return new List<Movie>         + var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);

            return View();

        }

    }// end class
}   // end namespace