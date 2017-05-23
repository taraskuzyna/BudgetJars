﻿using System;
using System.Collections.Generic;

namespace BudgetJars.API.DAL.Repository
{
    public interface IRepository<T> : IDisposable where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
