using Health.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static Health.BLL.DTOs.DoctorDTO.ResultDoctorDTO;

namespace Health.BLL.Abstract
{
    public interface IDoctorService
    {
        Doctor GetDoctor(int id);
        IEnumerable<Doctor> GetAllDoctors();
        IEnumerable<Doctor> FindDoctors(Expression<Func<Doctor, bool>> predicate);
        void AddDoctor(Doctor doctorDto);
        void UpdateDoctor(Doctor doctorDto);
        void DeleteDoctor(Doctor doctorDto);
    }
}
