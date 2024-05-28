using Health.BLL.Abstract;
using Health.BLL.DTOs.DoctorDTO;
using Health.DAL.Abstract;
using Health.Entity;
using System.Linq.Expressions;

namespace Health.BLL.Concrete
{
    public class DoctorManager : IDoctorService
    {
        private readonly IDoctorDal _doctorDal;

        public DoctorManager(IDoctorDal doctorDal)
        {
            _doctorDal = doctorDal;
        }

        public void AddDoctor(Doctor doctorDto)
        {
             _doctorDal.Add(doctorDto);
        }

        public void DeleteDoctor(Doctor doctorDto)
        {
             _doctorDal.Delete(doctorDto);
        }

        public IEnumerable<Doctor> FindDoctors(Expression<Func<Doctor, bool>> predicate)
        {
            return _doctorDal.Find(predicate);
        }

        public IEnumerable<Doctor> GetAllDoctors()
        {
            return _doctorDal.GetAll();
        }

        public Doctor GetDoctor(int id)
        {
            return _doctorDal.Get(id);
        }

        public void UpdateDoctor(Doctor doctorDto)
        {
            _doctorDal.Update(doctorDto);
        }
    }
}