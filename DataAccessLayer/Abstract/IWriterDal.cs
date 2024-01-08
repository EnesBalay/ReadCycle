using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IWriterDal:IGenericDal<Writer>
    {
        public Writer GetWriterWithIdentityName(string name);
        public List<Writer> GetWritersBySearch(string search);

    }
}
