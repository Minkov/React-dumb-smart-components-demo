using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TodoApp.Data;
using TodoApp.Models;
using TodoApp.Services.Contracts;
using TodoApp.ViewModels;

namespace TodoApp.Controllers
{
    [Route("/api/[controller]/{id?}")]
    public class TodosController : Controller
    {
        private readonly ITodosService todosService;

        public TodosController(ITodosService todosService) =>
            this.todosService = todosService;

        [HttpGet]
        public ActionResult GetAll()
        {
            var vms = this.todosService.GetAllTodos()
                .Select(TodoViewModel.FromModel);

            return this.Json(vms);
        }

        [HttpPost]
        public ActionResult Create([FromBody] TodoCreateViewModel viewModel)
        {
            var todo = this.todosService.CreateTodo(viewModel.Title, viewModel.Text);
            var vm = TodoViewModel.FromModel(todo);

            return this.Json(vm);
        }

        [HttpPut]
        public ActionResult Update(int id)
        {
            var todo = this.todosService.ChangeTodoState(id);
            var vm = TodoViewModel.FromModel(todo);
            return this.Json(vm);
        }
    }
}