using Health.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health.BLL.Abstract
{
    public interface IAboutService
    {
        About GetOne();
        void Update(About entity);
    }
}
