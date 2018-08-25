using System.Collections.Generic;
using TodoApp.Models;

namespace TodoApp.Services.Contracts
{
    public interface ITodosService
    {
        IEnumerable<Todo> GetAllTodos();

        Todo CreateTodo(string title, string text);

        Todo GetTodoById(int id);
        Todo ChangeTodoState(int id);
    }
}