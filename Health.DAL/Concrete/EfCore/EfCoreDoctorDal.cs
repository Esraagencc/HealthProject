using Health.DAL.Abstract;
using Health.DAL.Concrete.EFCore;
using Health.Entity;
using Microsoft.EntityFrameworkCore;

namespace Health.DAL.Concrete.EfCore
{
    public class EfCoreDoctorDal : EfCoreRepository<Doctor, DataContext>, IDoctorDal
    {
        private readonly DataContext _dataContext;

        public EfCoreDoctorDal(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IEnumerable<Doctor> GetDoctorAllBranch()
        {
            return _dataContext.Doctors
                .Include(b => b.Branch)
                .ToList();
        }

        public Doctor GetDoctorById(int id)
        {
            return _dataContext.Doctors
                .Include(b => b.Branch)
                .Where(b => b.Id == id).FirstOrDefault();
        }
    }
}
