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
    internal class BookManager: IBookService
    {
        IBookDal _bookDal;
        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }
        public void Add(Book t)
        {
            _bookDal.Add(t);
        }

        public Book GetById(int id)
        {
            return _bookDal.GetByID(id);
        }

        public List<Book> GetListAll()
        {
            return _bookDal.GetAll();
        }

        public Book GetBookByName(string bookName)
        {
            return _bookDal.GetBookWithIdentityName(bookName);
        }

        public List<Book> GetBookBySearch(string search)
        {
            return _bookDal.GetBooksBySearch(search);
        }

        public void Remove(Book t)
        {
            _bookDal.Delete(t);
        }

        public void Update(Book t)
        {
            _bookDal.Update(t);
        }
    }
}
