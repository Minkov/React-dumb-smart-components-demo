using System;
using TodoApp.Models;

namespace TodoApp.ViewModels
{
    public class TodoViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime ModifiedOn { get; set; }
        public bool IsDone { get; set; }

        public static TodoViewModel FromModel(Todo todo)
        {
            return new TodoViewModel
            {
                Id = todo.Id,
                Title = todo.Title,
                Text = todo.Text,
                ModifiedOn = todo.ModifiedOn,
                IsDone = todo.TodoState == TodoState.Done
            };
        }
    }
}