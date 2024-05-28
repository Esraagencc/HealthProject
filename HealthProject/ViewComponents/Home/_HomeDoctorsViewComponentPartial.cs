using AutoMapper;
using Health.BLL.Abstract;
using Health.BLL.DTOs.DoctorDTO;
using Microsoft.AspNetCore.Mvc;

namespace HealthProject.ViewComponents.Home
{
    public class _HomeDoctorsViewComponentPartial : ViewComponent
    {
        private readonly IDoctorService _doctorService;
        private readonly IMapper _mapper;

        public _HomeDoctorsViewComponentPartial(IDoctorService doctorService, IMapper mapper)
        {
            _doctorService = doctorService;
            _mapper = mapper;
        }
        public IViewComponentResult Invoke()
        {
            var doctors = _doctorService.FindDoctors(x=>x.Status==true);

            var dtoDoctors = _mapper.Map<List<ResultDoctorDTO>>(doctors);

            return View(dtoDoctors);
        }
    }
}
