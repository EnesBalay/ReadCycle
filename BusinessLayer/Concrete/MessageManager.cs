using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    internal class MessageManager : IMessageService
    {
        IMessageDal _messageDal;
        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }
        public void Add(Message t)
        {
            _messageDal.Add(t);
        }

        public Message GetById(int id)
        {
            return _messageDal.GetByID(id);
        }

        public List<Message> GetListAll()
        {
            return _messageDal.GetAll();
        }

        public Message GetMessageByText(string messageText)
        {
            return _messageDal.GetMessageWithIdentityName(messageText);
        }

        public List<Message> GetMessageBySearch(string search)
        {
            return _messageDal.GetMessagesBySearch(search);
        }

        public void Remove(Message t)
        {
            _messageDal.Delete(t);
        }

        public void Update(Message t)
        {
            _messageDal.Update(t);
        }
    }
}
