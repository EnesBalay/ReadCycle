using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IBookAdDal:IGenericDal<BookAd>
    {
        public BookAd GetBookAdWithIdentityName(string title);
        public List<BookAd> GetBookAdsBySearch(string search);
        public List<BookAd> GetAllByIncludes();

    }
}
