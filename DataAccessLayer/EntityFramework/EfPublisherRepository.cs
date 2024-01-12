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
    public class EfPublisherRepository : GenericRepository<Publisher>, IPublisherDal
    {
        public List<Publisher> GetPublishersBySearch(string search)
        {
            using var c = new Context();
            return c.Publishers.Where(x => x.Name.ToLower().Contains(search.ToLower())).ToList();
        }

        public Publisher GetPublisherWithIdentityName(string name)
        {
            using var c = new Context();
            return c.Publishers.FirstOrDefault(x => x.Name == name);
        }

    }
}
