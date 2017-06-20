using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using RitualReminders.Dtos;
using RitualReminders.Models;

namespace RitualReminders.Controllers.Api
{
    public class TodosController : ApiController
    {
        private ApplicationDbContext _context;

        public TodosController()
        {
            _context = new ApplicationDbContext();
        }

        // GET /api/todos
        public IHttpActionResult GetTodosByUser(string userName)
        {
            //var todos = _context.ToDos.ToList().Select(Mapper.Map<Todo, TodoDto>);

            //var todos = _context.ToDos(Mapper.Map<Todo, TodoDto>).Where(t => t.ApplicationUser.UserName == userName);


            if (string.IsNullOrEmpty(userName))
            {
                return BadRequest("Invalid User Name");
               
               
            }

            var todosDtos = _context.ToDos.Where(t => t.ApplicationUser.UserName == userName).Select(Mapper.Map<Todo, TodoDto>);

           /* todos = _context.ToDos.Where(t => t.ApplicationUser.UserName == userName);

            var todosQuery = _context.ToDos.Where(t => t.ApplicationUser.UserName == userName);*/



            // todosQuery = todosQuery.Select(Mapper.Map<Todo, TodoDto>).ToList();

            //var todosQuery = _context.ToDos.ToList().Select(Mapper.Map<Todo, TodoDto>);

            // todosQuery = todosQuery.Where(c => c.ApplicationUser.UserName.Contains(userName));

            /*            var todoDtos = todosQuery
                            .ToList()
                            .Select();

                        Ok<IEnumerable<Album>>(rockband.Albums);*/

            return Ok(todosDtos);
            
        }

        // GET /api/todos
        public IEnumerable<TodoDto> GetTodos()
        {
            return _context.ToDos.ToList().Select(Mapper.Map<Todo, TodoDto>);
        }

        /*public IHttpActionResult GetTodos(string query = null)
        {
            var todosQuery = _context.ToDos.Include(t => t.TO)Include(c => c.TodoSnoozes);

            if (!String.IsNullOrWhiteSpace(query))
                todosQuery = todosQuery.Where(c => c.Title.Contains(query));

            var todoDtos = todosQuery
                .ToList()
                .Select(Mapper.Map<Todo, TodoDto>);

            return Ok(todoDtos);
        }*/

        // GET /api/todos/1
        public IHttpActionResult Gettodo(int id)
        {
            var todo = _context.ToDos.SingleOrDefault(t => t.ToDoId == id);

            if (todo == null)
                return NotFound();

            return Ok(Mapper.Map<Todo, TodoDto>(todo));
        }

        // POST /api/todos
        [HttpPost]       
        public IHttpActionResult Createtodo(TodoDto todoDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var todo = Mapper.Map<TodoDto, Todo>(todoDto);
            _context.ToDos.Add(todo);
            _context.SaveChanges();

            todoDto.ToDoId = todo.ToDoId;
            return Created(new Uri(Request.RequestUri + "/" + todo.ToDoId), todoDto);
        }

        // PUT /api/todos/1
        [HttpPut]
        public IHttpActionResult Updatetodo(int id, TodoDto todoDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var todoInDb = _context.ToDos.SingleOrDefault(c => c.ToDoId == id);

            if (todoInDb == null)
                return NotFound();

            Mapper.Map(todoDto, todoInDb);

            _context.SaveChanges();

            return Ok();
        }

        // DELETE /api/todos/1
        [HttpDelete]
        public IHttpActionResult Deletetodo(int id)
        {
            var todoInDb = _context.ToDos.SingleOrDefault(c => c.ToDoId == id);

            if (todoInDb == null)
                return NotFound();

            _context.ToDos.Remove(todoInDb);
            _context.SaveChanges();

            return Ok();
        }
    }
}
