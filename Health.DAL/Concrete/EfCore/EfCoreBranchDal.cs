using Health.DAL.Abstract;
using Health.DAL.Concrete.EFCore;
using Health.Entity;
using Microsoft.EntityFrameworkCore;

namespace Health.DAL.Concrete.EfCore
{
    public class EfCoreBranchDal : EfCoreRepository<Branch, DataContext>, IBranchDal
    {
        private readonly DataContext _context;

        public EfCoreBranchDal(DataContext dataContext)
        {
            _context = dataContext;
        }

        public IQueryable<Branch> GetAllBranch()
        {
            return _context.Branchs.AsNoTracking();
        }
    }
}
