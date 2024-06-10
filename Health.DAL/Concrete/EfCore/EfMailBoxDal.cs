using Health.DAL.Abstract;
using Health.DAL.Concrete.EFCore;
using Health.Entity;

namespace Health.DAL.Concrete.EfCore
{
    public class EfMailBoxDal : EfCoreRepository<MailBox, DataContext> , IMailBoxDal
    {
    }
}
