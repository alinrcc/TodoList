﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.Models;
using TodoList.Repository.Abstract;

namespace TodoList.Repository.Shared.Abstract
{
    public interface IUnitOfWork
    {
        IRepository<AppUser> AppUsers { get; }
        IToDoRepository ToDos { get; }
        IRepository<Category> Categories { get; }
        IRepository<UserType> UserTypes { get; }

        void Save();
    }
}
