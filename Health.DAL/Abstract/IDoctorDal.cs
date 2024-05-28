using Health.Entity;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health.DAL.Abstract
{
    public interface IDoctorDal:IRepository<Doctor>
    {
    }
}
