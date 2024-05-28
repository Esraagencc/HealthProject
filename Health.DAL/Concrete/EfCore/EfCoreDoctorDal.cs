using Health.DAL.Abstract;
using Health.DAL.Concrete.EFCore;
using Health.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health.DAL.Concrete.EfCore
{
    public class EfCoreDoctorDal : EfCoreRepository<Doctor, DataContext>, IDoctorDal
    {
    }
}
