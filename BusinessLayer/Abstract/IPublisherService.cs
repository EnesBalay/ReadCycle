using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    internal interface IPublisherService : IGenericService<Publisher>
    {
        public Publisher GetPublisherByName(String name);
        public List<Publisher> GetPublisherBySearch(String search);
    }
}
