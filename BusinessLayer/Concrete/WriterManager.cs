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
    internal class WriterManager : IWriterService
    {
        IWriterDal _writerDal;
        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }
        public void Add(Writer t)
        {
            _writerDal.Add(t);
        }

        public Writer GetById(int id)
        {
            return _writerDal.GetByID(id);
        }

        public List<Writer> GetListAll()
        {
            return _writerDal.GetAll();
        }

        public Writer GetWriterByName(string name)
        {
            return _writerDal.GetWriterWithIdentityName(name);
        }

        public List<Writer> GetWriterBySearch(string search)
        {
            return _writerDal.GetWritersBySearch(search);
        }

        public void Remove(Writer t)
        {
            _writerDal.Delete(t);
        }

        public void Update(Writer t)
        {
            _writerDal.Update(t);
        }
    }
}
