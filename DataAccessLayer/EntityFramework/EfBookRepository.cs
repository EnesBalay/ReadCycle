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
    public class EfBookRepository : GenericRepository<Book>, IBookDal
    {
        public List<Book> GetBooksBySearch(string search)
        {
            using var c = new Context();
            return c.Books.Where(x => x.Name.ToLower().Contains(search.ToLower())).ToList();
        }

        public Book GetBookWithIdentityName(string bookName)
        {
            using var c = new Context();
            return c.Books.FirstOrDefault(x => x.Name == bookName);
        }

    }
}
