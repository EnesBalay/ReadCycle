using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IPublisherDal:IGenericDal<Publisher>
    {
        public Publisher GetPublisherWithIdentityName(string name);
        public List<Publisher> GetPublishersBySearch(string search);

    }
}
