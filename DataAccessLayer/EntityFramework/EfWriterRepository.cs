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
    public class EfWriterRepository : GenericRepository<Writer>, IWriterDal
    {
        public List<Writer> GetWritersBySearch(string search)
        {
            using var c = new Context();
            return c.Writers.Where(x => x.Name.ToLower().Contains(search.ToLower())).ToList();
        }

        public Writer GetWriterWithIdentityName(string name)
        {
            using var c = new Context();
            return c.Writers.FirstOrDefault(x => x.Name == name);
        }

    }
}
