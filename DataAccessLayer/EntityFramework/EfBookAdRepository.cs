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
    public class EfBookAdRepository : GenericRepository<BookAd>, IBookAdDal
    {
        public List<BookAd> GetBookAdsBySearch(string search)
        {
            using var c = new Context();
            return c.BookAds.Where(x => x.Title.ToLower().Contains(search.ToLower())).ToList();
        }

        public BookAd GetBookAdWithIdentityName(string title)
        {
            using var c = new Context();
            return c.BookAds.FirstOrDefault(x => x.Title == title);
        }

    }
}
