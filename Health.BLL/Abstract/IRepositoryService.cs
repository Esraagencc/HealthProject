﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Health.BLL.Abstract
{
    public interface IRepositoryService<T>
    {
        IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null);
        T GetById(int id);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    
    }
}
