using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IUserDal:IGenericDal<User>
    {
        public User GetUserWithIdentityName(string emailAddress);
        public List<User> GetUsersBySearch(string search);
    }
}
