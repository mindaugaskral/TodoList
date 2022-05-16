﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.Models;
using TodoList.Services;

namespace TodoList.Controllers
{
    public class ToDoController : Controller
    {
        private TodosService _todosService;
        public ToDoController(TodosService todosService)
        {
            _todosService = todosService;
        }
        public IActionResult Index()
        {
            var todos = _todosService.GetAll();
            return View(todos);
        }

        [HttpGet]
        public IActionResult Add()
        {
            Todo todo =  new Todo();
            return View(todo);
        }
        
        [HttpPost]
        public IActionResult Add(Todo todo)
        {
            _todosService.Add(todo);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(string name)
        {
            _todosService.Delete(name);
            return RedirectToAction("Index");
        }
    }
}
