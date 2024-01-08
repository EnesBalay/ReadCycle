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
    internal class PublisherManager : IPublisherService
    {
        IPublisherDal _publisherDal;
        public PublisherManager(IPublisherDal publisherDal)
        {
            _publisherDal = publisherDal;
        }
        public void Add(Publisher t)
        {
            _publisherDal.Add(t);
        }

        public Publisher GetById(int id)
        {
            return _publisherDal.GetByID(id);
        }

        public List<Publisher> GetListAll()
        {
            return _publisherDal.GetAll();
        }

        public Publisher GetPublisherByName(string name)
        {
            return _publisherDal.GetPublisherWithIdentityName(name);
        }

        public List<Publisher> GetPublisherBySearch(string search)
        {
            return _publisherDal.GetPublishersBySearch(search);
        }

        public void Remove(Publisher t)
        {
            _publisherDal.Delete(t);
        }

        public void Update(Publisher t)
        {
            _publisherDal.Update(t);
        }
    }
}
