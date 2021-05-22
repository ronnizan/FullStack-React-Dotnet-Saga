using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Interfaces;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ITodoLogic _todoLogic;

        public TodosController(ITodoLogic todoLogic)
        {
            _todoLogic = todoLogic;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public  ActionResult<List<Todo>> GetTodos()
        {
            var todos =  _todoLogic.GetTodos();
            return Ok(todos);
        }


        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Todo> GetTodo(int id)
        {
            var todo =  _todoLogic.GetTodo(id);

            if (todo is null)
            {
                return NotFound();
            }

            return Ok(todo);
        }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public  ActionResult<Todo> CreateTodo(Todo createTodoModel)
        {
            var todoModel = new Todo
            {
                id = createTodoModel.id,
                description = createTodoModel.description,
                isCompleted = createTodoModel.isCompleted
            };

            var createdTodo = _todoLogic.CreateTodo(todoModel);

            return Ok(createdTodo);
        }


        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public  ActionResult UpdateTodoAsync(int id, Todo updateTodoModel)
        {
            if (id != updateTodoModel.id)
            {
                return BadRequest();
            }

            var todo =  _todoLogic.GetTodo(id);
            if (todo is null)
            {
                return NotFound();
            }

            var todoModel = new Todo
            {
                id = id,
                description = updateTodoModel.description,
                isCompleted = updateTodoModel.isCompleted,
            };

            var updatedTodo =  _todoLogic.UpdateTodo(todoModel);

            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public  ActionResult DeleteTodo(int id)
        {
            var todo = _todoLogic.GetTodo(id);
            if (todo is null)
            {
                return NotFound();
            }

             _todoLogic.DeleteTodo(id);
            return NoContent();
        }

    }


}

