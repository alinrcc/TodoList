﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.Data;
using TodoList.Models;
using TodoList.Repository.Abstract;
using TodoList.Repository.Shared.Concrete;

namespace TodoList.Repository.Concrete
{
    public class ToDoRepository : Repository<ToDo>, IToDoRepository
    {
        private readonly ApplicationDbContext _context;
        public ToDoRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public void SetIsActive(int id)
        {
            ToDo todo = _context.ToDos.Find(id);
            todo.IsActive = false;
            _context.ToDos.Update(todo);
           
         
        }
    }
}
