﻿using Health.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health.DAL.Abstract
{
    public interface IBranchDal:IRepository<Branch>
    {

        IQueryable<Branch> GetAllBrach();
    }
}