using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IBookDal:IGenericDal<Book>
    {
        public Book GetBookWithIdentityName(string bookName);
        public List<Book> GetBooksBySearch(string search);

    }
}
