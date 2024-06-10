using Health.DAL.Abstract;
using Health.Entity;
using HealthProject.Entity;

namespace Health.BLL.Abstract
{
    public interface IMailBoxService : IRepositoryService<MailBox>
    {
        IEnumerable<MailBox> GetMailBoxes();

        void AddMailBox(SendMailModel createMailBox);

    }
}
