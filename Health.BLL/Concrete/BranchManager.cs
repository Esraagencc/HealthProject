using Health.BLL.Abstract;
using Health.DAL.Abstract;
using Health.Entity;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Health.BLL.Concrete
{
    public class BranchManager : IBranchService
    {
        private readonly IBranchDal _branchDal;
        public BranchManager(IBranchDal tdal)
        {
            _branchDal = tdal;
        }

        public void Create(Branch entity)
        {
            _branchDal.Add(entity);
        }

        public void Delete(Branch entity)
        {
            _branchDal.Delete(entity);
        }

        public IEnumerable<Branch> GetAll(Expression<Func<Branch, bool>> filter = null)
        {
            return _branchDal.GetAll();
        }

        public IQueryable<Branch> GetAllBrach()
        {
            return _branchDal.GetAllBrach();
        }

        public Branch GetById(int id)
        {
            return _branchDal.Get(id);
        }

        public void Update(Branch entity)
        {
            _branchDal.Update(entity);
            
        }
    }
}
