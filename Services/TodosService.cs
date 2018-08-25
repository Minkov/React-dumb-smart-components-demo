using System;
using System.Collections.Generic;
using System.Linq;
using TodoApp.Data;
using TodoApp.Models;
using TodoApp.Services.Contracts;

namespace TodoApp.Services
{
    public class TodosService : ITodosService
    {
        private readonly ApplicationDbContext dbContext;

        public TodosService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Todo CreateTodo(string title, string text)
        {
            Todo todo = new Todo
            {
                Title = title,
                Text = text,
                CreatedOn = DateTime.Now,
                ModifiedOn = DateTime.Now,
                TodoState = TodoState.NotDone,
                IsDeleted = false
            };
            this.dbContext.Todos.Add(todo);

            this.dbContext.SaveChanges();

            return todo;
        }

        public IEnumerable<Todo> GetAllTodos() =>
             this.dbContext.Todos.ToList();

        public Todo GetTodoById(int id) =>
            this.dbContext.Todos.Find(id);

        public Todo ChangeTodoState(int id)
        {
            var todo = this.dbContext.Todos.Find(id);
            todo.TodoState = todo.TodoState == TodoState.Done
                ? TodoState.NotDone
                : TodoState.Done;

            this.dbContext.SaveChanges();
            return todo;
        }
    }
}