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
    public class BookAdManager : IBookAdService
    {
        IBookAdDal _bookAdDal;
        public BookAdManager(IBookAdDal bookAdDal)
        {
            _bookAdDal = bookAdDal;
        }
        public void Add(BookAd t)
        {
            _bookAdDal.Add(t);
        }

        public BookAd GetById(int id)
        {
            return _bookAdDal.GetByID(id);
        }

        public List<BookAd> GetListAll()
        {
            return _bookAdDal.GetAll();
        }

        public BookAd GetBookAdByTitle(string emailAddress)
        {
            return _bookAdDal.GetBookAdWithIdentityName(emailAddress);
        }

        public List<BookAd> GetBookAdBySearch(string search)
        {
            return _bookAdDal.GetBookAdsBySearch(search);
        }

        public void Remove(BookAd t)
        {
            _bookAdDal.Delete(t);
        }

        public void Update(BookAd t)
        {
            _bookAdDal.Update(t);
        }
        public List<BookAd> GetAllByIncludes()
        {
            return _bookAdDal.GetAllByIncludes();
        }
    }
}
