using Health.BLL.Abstract;
using Health.DAL.Abstract;
using Health.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health.BLL.Concrete
{
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutDal;
        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }
        public About GetOne()
        {
            return _aboutDal.GetOne();
        }

        public void Update(About entity)
        {
            _aboutDal.Update(entity);
        }
    }
}
