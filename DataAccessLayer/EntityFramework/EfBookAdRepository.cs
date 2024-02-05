using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
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
        public List<BookAd> GetAllByIncludes()
        {
            using var c = new Context();
            return c.BookAds
                .Include(x => x.Book)
                .Include(x => x.User)
                .ToList();

        }
        public BookAd GetByID(int id)
        {
            using var c = new Context();
            return c.BookAds.Include(x => x.User).Include(x => x.Book).First(x => x.Id == id);
        }
    }
}
