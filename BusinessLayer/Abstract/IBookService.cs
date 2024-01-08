using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    internal interface IBookService:IGenericService<Book>
    {
        public Book GetBookByName(String bookName);
        public List<Book> GetBookBySearch(String search);
    }
}
