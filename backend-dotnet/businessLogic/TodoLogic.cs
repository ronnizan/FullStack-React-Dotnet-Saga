using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Interfaces;
using WebApplication2.Models;

namespace WebApplication2.Business_Logic
{
    public class TodoLogic : ITodoLogic
    {

        private static List<Todo> todos = new List<Todo>() { new Todo { id = 1, description = "wow", isCompleted = true } };


        public Todo CreateTodo(Todo recivedTodo)
        {
            var todo = new Todo { description = recivedTodo.description, id=recivedTodo.id, isCompleted=recivedTodo.isCompleted };
            todos.Add(todo);
            return todo;
        }

        public List<Todo> DeleteTodo(int todoId)
        {
            var itemToRemove = todos.Single(t => t.id == todoId);
            todos.Remove(itemToRemove);
            return todos;
        }

        public Todo GetTodo(int todoId)
        {
            var todo = todos.FirstOrDefault(todo => todo.id == todoId);
            return todo;
        }

        public List<Todo> GetTodos()
        {
            return todos;
        }

        public Todo UpdateTodo(Todo todoModel)
        {
            int index = todos.FindIndex(t => t.id == todoModel.id);
            if (index >= 0)
            {
                todos[index] = todoModel;
            }
                
            return todos[index];
        }
    }
}
