using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Interfaces
{
   public interface ITodoLogic
    {
        Todo CreateTodo(Todo todoModel);
        Todo UpdateTodo(Todo todoModel);
        Todo GetTodo(int todoId);
        List<Todo> DeleteTodo(int todoId);
        List<Todo> GetTodos();

    }
}
