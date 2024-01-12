using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfMessageRepository : GenericRepository<Message>, IMessageDal
    {
        public List<Message> GetMessagesBySearch(string search)
        {
            using var c = new Context();
            return c.Messages.Where(x => x.MessageText.ToLower().Contains(search.ToLower())).ToList();
        }

        public Message GetMessageWithIdentityName(string text)
        {
            using var c = new Context();
            return c.Messages.FirstOrDefault(x => x.MessageText == text);
        }

    }
}
