using Health.BLL.Abstract;
using Health.DAL.Abstract;
using Health.Entity;
using HealthProject.Entity;
using System.Linq.Expressions;

namespace Health.BLL.Concrete
{
    public class MailBoxManager : IMailBoxService
    {
        private readonly IMailBoxDal _mailBoxDal;
        public MailBoxManager(IMailBoxDal tdal) 
        {
            _mailBoxDal = tdal;
        }

        public void AddMailBox(SendMailModel createMailBox)
        {
            _mailBoxDal.Add(new MailBox()
            {
                FullName = createMailBox.FullName,
                Department = createMailBox.Department,
                Message = createMailBox.Message,    
                Phone = createMailBox.Phone,
                RandevuDate = createMailBox.RandevuDate,
                SendEmail = createMailBox.SendEmail,    
            });


        }

        public void Create(MailBox entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(MailBox entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MailBox> GetAll(Expression<Func<MailBox, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public MailBox GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MailBox> GetMailBoxes()
        {
            return _mailBoxDal.GetAll();
        }

        public void Update(MailBox entity)
        {
            throw new NotImplementedException();
        }
    }
}
