using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IMessageDal:IGenericDal<Message>
    {
        public Message GetMessageWithIdentityName(string messageText);
        public List<Message> GetMessagesBySearch(string search);
    }
}
