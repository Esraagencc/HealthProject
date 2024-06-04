using AutoMapper;
using Health.BLL.DTOs.DoctorDTO;
using Health.Entity;
using static Health.BLL.DTOs.DoctorDTO.ResultDoctorDTO;

namespace HealthProject.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
         
            CreateMap<Doctor, ResultDoctorDTO>().ReverseMap();
        }
        
    }
}
