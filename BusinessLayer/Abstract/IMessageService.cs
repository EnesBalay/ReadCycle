using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    internal interface IMessageService : IGenericService<Message>
    {
        public Message GetMessageByText(String text);
        public List<Message> GetMessageBySearch(String search);
    }
}
